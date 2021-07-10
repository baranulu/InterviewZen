using System;
using System.Collections;
using System.Collections.Generic;

namespace KitapSiparis
{
    public class Yazar
    {
        public int YazarId { get; set; }
        public string YazarAdı { get; set; }
        public string YazarSoyadı { get; set; }
        public ICollection<Kitap> kitaps { get; set; }
    }
    
}
