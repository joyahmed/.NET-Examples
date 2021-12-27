﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core2._2Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string City { get; set; }
    }
}