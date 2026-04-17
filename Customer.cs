using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }

        // كل عميل عنده Orders
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
