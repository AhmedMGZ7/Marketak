using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marketak.Models
{
    public class Ads
    {
        public string Name { get; set; }
        public string Photo { get; set; }
        public float paidPerMonth { get; set; }
        public string CompanyName { get; set; }
        public string SDate { get; set; }
        public string EDate { get; set; }

    }
}