using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Marketak.Models
{
    public class ProductModel
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public string CompanyName { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public float SalePercentage { get; set; }
        public string Description { get; set; }
        public float Rating { get; set; }
        public int NoOfrating { get; set; }
        public int Color { get; set; }
        public string Photo { get; set; }


    }
}