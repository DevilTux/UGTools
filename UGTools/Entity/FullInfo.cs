using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UGTools.Entity
{
    public class FullInfo
    {
        #region personal

        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }
        public virtual DateTime Birthday { get; set; }
        public virtual Sex Sex { get; set; }
        public virtual string Email { get; set; }

        #endregion
        
        #region credicard

        public virtual CardType CardType { get; set; }
        public virtual string CardNumber { get; set; }
        public virtual int Cvn { get; set; }
        public virtual string ExpiredMonth { get; set; }
        public virtual string ExpiredYear { get; set; }
        public virtual string Owner { get; set; }
        public virtual string IssuingBank { get; set; }

        #endregion

        #region address
        public virtual string Address1 { set; get; }
        public virtual string Address2 { set; get; }
        public virtual string City { set; get; }
        public virtual string State { set; get; }
        public virtual string Zipcode { get; set; }
        public virtual string ZipcodeEx { get; set; }
        public virtual string County { get; set; }
        public virtual string Country { get; set; }
        public virtual string PhoneNumber { get; set; }
        #endregion

        #region authentication
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        #endregion
    }
}
