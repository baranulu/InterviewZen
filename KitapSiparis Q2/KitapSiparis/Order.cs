using System;
using System.Collections.Generic;
using System.Text;

namespace KitapSiparis
{
   public class Order
    {

        public int OrderNo { get; set; }
        public decimal OrderPrice{ get; set; }

        public Customer Customer { get; set; }


    }
}
