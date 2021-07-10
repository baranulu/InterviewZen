using System;
using System.Collections.Generic;
using System.Text;

namespace KitapSiparis
{
    class KitapSiparis
    {
        public int KitapId { get; set; }
        public int SiparisId { get; set; }

        public Kitap Kitap { get; set; }
        public Siparis Siparis { get; set; }
    }
}
