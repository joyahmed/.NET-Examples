using ShoppingCartEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartEF.Data
{
    public class Order
    {
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string Price { get; set; }
        public bool Paid { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
