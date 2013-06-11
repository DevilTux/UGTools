using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UGTools.Entity
{
    public class Personal
    {
        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }

        public virtual DateTime Birthday { get; set; }
        public Sex Sex { get; set; }
        public virtual string Email { get; set; }

        public BillingInfo Address { get; set; }
        public CreditCard CreditCard { get; set; }
        public Account Authentication { get; set; }
    }

    public enum Sex
    {
        Unknown,
        Male,
        Female
    }
}
