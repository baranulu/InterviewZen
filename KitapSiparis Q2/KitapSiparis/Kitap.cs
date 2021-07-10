using System;
using System.Collections.Generic;
using System.Text;

namespace KitapSiparis
{
   public class Kitap
    {
        public string KitapAdı { get; set; }
        public string KitapTür { get; set; }
        public string YayınEvi { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitİnStock { get; set; }
        public Yazar Yazar { get; set; }
    }
}
