using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartEF.Models
{
    public class Cart
    {
        public Program Product { get; set; }
        public int Amount { get; set; }
    }
}
