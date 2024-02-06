using System;
using System.Collections.Generic;

namespace WebApp2CoreFeb6.Model
{
    public partial class LogInCdt
    {
        public LogInCdt()
        {
            Banks = new HashSet<Bank>();
        }

        public string PhoneNumber { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Passwordd { get; set; } = null!;
        public string EmailId { get; set; } = null!;

        public virtual ICollection<Bank> Banks { get; set; }
    }
}
