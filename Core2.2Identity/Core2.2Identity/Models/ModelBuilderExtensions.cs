using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core2._2Identity.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                    new Employee
                    {
                        Id = 4,
                        Name = "Mary"
                        //Department = Dept.IT,
                        //Email = "mary@pragimtech.com"
                    },
                    new Employee
                    {
                        Id = 5,
                        Name = "John"
                        //Department = Dept.HR,
                        //Email = "john@pragimtech.com"
                    }
                );
        }
    }
}
