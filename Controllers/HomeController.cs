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

        public ActionResult Delivery()
        {
            List<Delivery> Del = new List<Delivery>();
            Del.Add(new Delivery { city = "Maadi", Companyname = "Otlob", Price=100,Time=12 });
            ViewData["Admin"] = UserName;
            return View(Del);
        }
        public ActionResult AddDelivery()
        {
           
            ViewData["Admin"] = UserName;
            return View();
        }

        public ActionResult EditDelivery(string City, string Company)
        {
            Delivery Del = new Delivery { city = City, Companyname = Company, Price = 100, Time = 12 };
            ViewData["Admin"] = UserName;
            return View(Del);
        }

        public ActionResult DeleteDelivery(string City, string Company)
        {
            Delivery Del = new Delivery { city = City, Companyname = Company, Price = 100, Time = 12 };
            ViewData["Admin"] = UserName;
            return View(Del);
        }

        public ActionResult Ads()
        {
            List<Ads> Ads = new List<Ads>();
            Ads.Add(new Ads { Name="Omg",CompanyName="KFC",SDate="15/11/1998", EDate = "15/11/1998" ,paidPerMonth=200,Photo= "https://i.pinimg.com/originals/8f/72/78/8f7278cc6d6c629dca76b8458b24f1fc.jpg" });
            ViewData["Admin"] = UserName;
            return View(Ads);
        }

        public ActionResult AddAds()
        {
            ViewData["Admin"] = UserName;
            return View();
        }

        public ActionResult EditAds(string Name)
        {

            Ads Ads = new Ads { Name = Name, CompanyName = "KFC", SDate = "15/11/1998", EDate = "15/11/1998", paidPerMonth = 200, Photo = "https://i.pinimg.com/originals/8f/72/78/8f7278cc6d6c629dca76b8458b24f1fc.jpg" };
            ViewData["Admin"] = UserName;
            return View(Ads);
        }

        public ActionResult DeleteAds(string Name)
        {
            Ads Ads = new Ads { Name = Name, CompanyName = "KFC", SDate = "15/11/1998", EDate = "15/11/1998", paidPerMonth = 200, Photo = "https://i.pinimg.com/originals/8f/72/78/8f7278cc6d6c629dca76b8458b24f1fc.jpg" };
            ViewData["Admin"] = UserName;
            return View(Ads);
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