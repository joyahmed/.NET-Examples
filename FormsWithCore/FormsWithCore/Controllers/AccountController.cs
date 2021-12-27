using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormsWithCore.Models;

namespace FormsWithCore.Controllers
{

    [Route("account")]
    public class AccountController : Controller
    {
        [Route("")]
        [Route("~/")]
        [Route("index")]

        public IActionResult Index()
        {
            var account = new Account()
            {
                Status = true;
            };

            return View("Index", account);
        }
        
        [HttpPost]
        [Route("save")]

        public IActionResult Save(Account account)
        {
            ViewBag.account = account;

            return View("Result");
        }
    }
}