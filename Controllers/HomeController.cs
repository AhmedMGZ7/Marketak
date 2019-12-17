using Marketak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary.BusinessLogic.DBController;
namespace Marketak.Controllers
{
   
    public class HomeController : Controller
    {

        string UserName = "Messi";

        public ActionResult Marketak()
        {
            ViewData["Admin"] = UserName;
            return View();
        }


        public ActionResult HomePage()
        {
            ViewData["Admin"] = UserName; 
            return View();
        }

        public ActionResult SignUp()
        {

            ViewData["Admin"] = UserName;
            return View();
        }

        public ActionResult Login()
        {
            ViewData["Admin"] = UserName;
            return View();
        }

        public ActionResult Products()
        {
            ViewData["Admin"] = UserName;
            List <ProductModel> Products = new List<ProductModel>();
            Products.Add(new ProductModel {ID =  15, Name = "coffe",CategoryName = "drinks",CompanyName =  "nescafe",Price =  15 ,Quantity = 15,SalePercentage = 10,Description = "Drinking copy",Rating = 3,NoOfrating = 15,Color = 255,Photo = "https://images.cardekho.com/images/featuredcarimages/-36/m3w21-0.jpg" });
            Products.Add(new ProductModel { ID = 15, Name = "coffe", CategoryName = "drinks", CompanyName = "nescafe", Price = 15, Quantity = 15, SalePercentage = 10, Description = "Drinking copy", Rating = 3, NoOfrating = 15, Color = 255, Photo = "https://images.cardekho.com/images/featuredcarimages/-36/m3w21-0.jpg" });
            return View(Products);
        }

        public ActionResult AddProduct()
        {
            ViewData["Admin"] = UserName;
            return View();
        }

        public ActionResult ProductsDetails(int id)
        {
            ViewData["Admin"] = UserName;
            ProductModel Cofee = new ProductModel { ID = id, Name = "coffe", CategoryName = "drinks", CompanyName = "nescafe", Price = 15, Quantity = 15, SalePercentage = 10, Description = "Drinking coffe", Rating = 3, NoOfrating = 15, Color = 255, Photo = "https://images.cardekho.com/images/featuredcarimages/-36/m3w21-0.jpg" };

            return View(Cofee);
        }


       
        public ActionResult MyCart()
        {
            ViewData["Admin"] = UserName;
            List<ProductModel> Products = new List<ProductModel>();
            Products.Add(new ProductModel { ID = 15, Name = "coffe", CategoryName = "drinks", CompanyName = "nescafe", Price = 15, Quantity = 15, SalePercentage = 10, Description = "Drinking copy", Rating = 3, NoOfrating = 15, Color = 255, Photo = "l;jhojhj" });

            return View(Products);
        }

        public ActionResult Shops()
        {
            List<Shops> Shops = new List<Shops>();
            Shops.Add(new Shops{ID=1,Location="Cairo",Phone=01015204433,MangerID=5});
            ViewData["Admin"] = UserName;
            return View(Shops);
        }

        public ActionResult CreateShops()
        {
            ViewData["Admin"] = UserName;
            return View();
        }
        public ActionResult EditShops(int id)
        {
            ViewData["Admin"] = UserName;
            Shops shop = new Shops { ID = id, Location = "Cairo", Phone = 01015204433, MangerID = 5 };
            return View(shop);
        }
        public ActionResult DeleteShops(int id)
        {
            ViewData["Admin"] = UserName;
            Shops shop = new Shops { ID = id, Location = "Cairo", Phone = 01015204433, MangerID = 5 };
            return View(shop);
        }


        public ActionResult Companies()
        {
            List<Company> company = new List<Company>();
            company.Add(new Company { Name = "Samsung", Email = "SamsungHR@samsung.com", TotalGain = 15000 });
            ViewData["Admin"] = UserName;
            return View(company);
        }

        public ActionResult AddCompany()
        {
            ViewData["Admin"] = UserName;
            return View();
        }

        public ActionResult EditCompany(string name)
        {
            Company company = new Company { Name = name, Email = "SamsungHR@samsung.com", TotalGain = 15000 };
            ViewData["Admin"] = UserName;
            return View(company);
        }

        public ActionResult DeleteCompany(string name)
        {
            Company company = new Company { Name = name, Email = "SamsungHR@samsung.com", TotalGain = 15000 };
            ViewData["Admin"] = UserName;
            return View(company);
        }


        public ActionResult Employee()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee {ID=1,FirstName="Messi",LastName="MGZ",Phone=01288166163,Email="MGZ@Y=yahoo.com",BirthDate="11-12-1999",salary=15000,ShopID=1,Functionality='M' });
            ViewData["Admin"] = UserName;
            return View(employees);
        }

        public ActionResult AddEmployee()
        {
            ViewData["Admin"] = UserName;
            return View();
        }

        public ActionResult EditEmployee(int id)
        {
            Employee employee = new Employee { ID = id, FirstName = "Messi", LastName = "MGZ", Phone = 01288166163, Email = "MGZ@Y=yahoo.com", BirthDate = "11-12-1999", salary = 15000, ShopID = 1, Functionality = 'M' };
            ViewData["Admin"] = UserName;
            return View(employee);
        }

        public ActionResult DeleteEmployee(int id)
        {
            Employee employee = new Employee { ID = id, FirstName = "Messi", LastName = "MGZ", Phone = 01288166163, Email = "MGZ@Y=yahoo.com", BirthDate = "11-12-1999", salary = 15000, ShopID = 1, Functionality = 'M' };
            ViewData["Admin"] = UserName;
            return View(employee);
        }


        public ActionResult AddDelivery()
        {
            ViewData["Admin"] = UserName;
            return View();
        }

        public ActionResult AddAds()
        {
            ViewData["Admin"] = UserName;
            return View();
        }


        public ActionResult Addinstallment()
        {
            ViewData["Admin"] = UserName;
            return View();
        }

        public ActionResult Order()
        {
            ViewData["Admin"] = UserName;
            return View();
        }

    }
}