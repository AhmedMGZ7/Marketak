using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marketak.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string ClientUserName { get; set; }
        public float Money { get; set; }
        public string Date { get; set; }
        public string city { get; set; }
        public string Companyname { get; set; }
    }
}