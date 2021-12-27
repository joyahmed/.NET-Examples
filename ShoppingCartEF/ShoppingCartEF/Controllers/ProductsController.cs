using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingCartEF.Data;
using ShoppingCartEF.Models;

namespace ShoppingCartEF.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ShoppingCartContext _context;
        public List<string> Images = new List<string>() {
            "image1.jpg", "image2.jpg", "image3.jpg", "image4.jpg"
        };
        public ProductsController(ShoppingCartContext context)
        {
            _context = context;
        }     

        public async Task<IActionResult> Index()
        {
            ViewBag.Cart = LocalData.Cart;
            ViewBag.Images = Images;
            return View(await _context.Product.ToListAsync());
        }

        public IActionResult Init()
        {
            Product product = _context.Product.FirstOrDefault();

            if (product == null)
            {
                int count = 0;
                int price = 50;
                string name = "My product";
                while (count < 12)
                {
                    Product p = new Product();
                    p.Name = name + (count + 1);
                    price = (price + (count * 20));
                    p.Price = price.ToString();

                    _context.Product.Add(p);
                    _context.SaveChanges();

                    count++;
                }
            }

            return RedirectToAction("Index");
        }

        public IActionResult AddToCart(int id)
        {
            Product product = _context.Product.Find(id);

            Cart c = LocalData.Cart.Where(i => i.Product.id == product.Id).FirstOrDefault();

            if (c == null)
            {
                Cart cart = new Cart();
                cart.Product = product;
                cart.Amount = 1;
                LocalData.Cart.Add(cart);
            }
            else
            {
                c.Amount += 1;
            }

            return RedirectToAction("Index");
        }
    }
}