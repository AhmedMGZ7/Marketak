using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marketak.Models
{
    public class Installment
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public int MonthsLeft { get; set; }
        public float LeftPerMonth { get; set; }
        public string ClientUserName { get; set; }
        public int ProductID { get; set; }
    }
}