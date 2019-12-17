using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marketak.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; }
        public int salary { get; set; }
        public int ShopID { get; set; }
        public char Functionality { get; set; }
    }
}