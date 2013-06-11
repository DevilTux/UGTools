using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UGTools.Entity
{
    public class BillingInfo
    {
        public virtual string Address1 { set; get; }
        public virtual string Address2 { set; get; }
        public virtual string City { set; get; }
        public virtual string State { set; get; }
        public virtual string Zipcode { get; set; }
        public virtual string ZipcodeEx { get; set; }
        public virtual string County { get; set; }
        public virtual string Country { get; set; }
        public virtual string PhoneNumber { get; set; }
    }
}
