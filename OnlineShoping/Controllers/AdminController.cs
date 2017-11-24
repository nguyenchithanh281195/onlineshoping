using OnlineShoping.BUS;
using OnlineShoping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoping.Controllers
{
    public class AdminController : Controller
    {
        ManufactureBUS bus = new ManufactureBUS();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Product()
        {
            return View();
        }

        public ActionResult AddProduct()
        {
            List<Catergory> catergories = new List<Catergory>();
            catergories.Add(new Catergory("Mobile"));
            catergories.Add(new Catergory("Tablet"));
            catergories.Add(new Catergory("Laptop"));
            List<Manufacture> m = bus.GetManufactures();
            ModelAddProduct model = new ModelAddProduct(catergories, m);
            return View(model);
        }

        public ActionResult ListProduct()
        {
            return View();
        }

        public ActionResult ProductUpdate()
        {
            return View();
        }
    }
}