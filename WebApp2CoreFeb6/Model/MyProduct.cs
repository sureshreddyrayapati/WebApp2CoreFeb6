using System;
using System.Collections.Generic;

namespace WebApp2CoreFeb6.Model
{
    public partial class MyProduct
    {
        public int Pid { get; set; }
        public string Pname { get; set; } = null!;
        public double? Pprice { get; set; }
        public DateTime? Pmd { get; set; }
        public DateTime? Ped { get; set; }
    }
}
