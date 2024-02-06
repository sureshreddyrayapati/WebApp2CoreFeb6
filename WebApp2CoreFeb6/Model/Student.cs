﻿using System;
using System.Collections.Generic;

namespace WebApp2CoreFeb6.Model
{
    public partial class Student
    {
        public int StdId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime Dob { get; set; }
        public int? ClassId { get; set; }

        public virtual Class? Class { get; set; }
    }
}
