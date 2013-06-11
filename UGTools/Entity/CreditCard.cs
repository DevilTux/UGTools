using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UGTools.Entity
{
    public class CreditCard
    {
        public CardType CardType { get; set; }
        public string CardNumber { get; set; }
        public int Cvn { get; set; }
        public string ExpiredMonth { get; set; }
        public string ExpiredYear { get; set; }
        public string Owner { get; set; }
        public string IssuingBank { get; set; }
    }

    public enum CardType
    {
        Visa,
        Maser,
        AE,
        Discover
    }
}
