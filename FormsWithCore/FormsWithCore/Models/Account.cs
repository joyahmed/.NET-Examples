using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsWithCore.Models
{
    public class Account
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Description { get; set; }

        public bool Status { get; set; }

        public string[] Languages { get; set; }
    }
}
