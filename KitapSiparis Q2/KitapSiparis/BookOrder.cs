using System;
using System.Collections.Generic;
using System.Text;

namespace KitapSiparis
{
    class BookOrder
    {
        public int BookId { get; set; }
        public int OrderId { get; set; }

        public Book Book { get; set; }
        public Order Order { get; set; }
    }
}
