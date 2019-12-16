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

        public ActionResult HomePage()
        {
            
            return View();
        }

        public ActionResult SignUp()
        {

            
            return View();
        }

        public ActionResult Login()
        {

            return View();
        }

        public ActionResult Products()
        {

             List <ProductModel> Products = new List<ProductModel>();
            Products.Add(new ProductModel {ID =  15, Name = "coffe",CategoryName = "drinks",CompanyName =  "nescafe",Price =  15 ,Quantity = 15,SalePercentage = 10,Description = "Drinking copy",Rating = 3,NoOfrating = 15,Color = 255,Photo = "l;jhojhj" });

            return View(Products);
        }

        public ActionResult ProductsDetails(int id)
        {

           ProductModel Cofee = new ProductModel { ID =id , Name = "coffe", CategoryName = "drinks", CompanyName = "nescafe", Price = 15, Quantity = 15, SalePercentage = 10, Description = "Drinking copy", Rating = 3, NoOfrating = 15, Color = 255, Photo = "l;jhojhj" };

            return View(Cofee);
        }


       
        public ActionResult MyCart()
        {
            List<ProductModel> Products = new List<ProductModel>();
            Products.Add(new ProductModel { ID = 15, Name = "coffe", CategoryName = "drinks", CompanyName = "nescafe", Price = 15, Quantity = 15, SalePercentage = 10, Description = "Drinking copy", Rating = 3, NoOfrating = 15, Color = 255, Photo = "l;jhojhj" });

            return View(Products);
        }

       

    }
}