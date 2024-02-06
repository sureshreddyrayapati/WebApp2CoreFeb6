using System;
using System.Collections.Generic;

namespace WebApp2CoreFeb6.Model
{
    public partial class Book
    {
        public int Bid { get; set; }
        public string Bname { get; set; } = null!;
        public double? Price { get; set; }
        public string Author { get; set; } = null!;
    }
}
