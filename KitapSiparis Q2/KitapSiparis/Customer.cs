using System;
using System.Collections.Generic;
using System.Text;

namespace KitapSiparis
{
   public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
