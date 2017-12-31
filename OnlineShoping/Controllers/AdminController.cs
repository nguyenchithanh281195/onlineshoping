using OnlineShoping.BUS;
using OnlineShoping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShopingLib;

namespace OnlineShoping.Controllers
{
    public class AdminController : Controller
    {
        ManufactureBUS bus = new ManufactureBUS();
        private List<ProductType> catergories=new List<ProductType>();
        List<Manufacturer> manufacturers=new List<Manufacturer>();
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
            catergories = ProductType.GetData<ProductType>("","");
            manufacturers = bus.GetManufactures();
            ModelAddProduct model = new ModelAddProduct(catergories, manufacturers);
            return View(model);
        }

        [HttpPost]
        public ActionResult AddProductSubmit()
        {
            OnlineShopingLib.Product p=new Product();
            p.Name = Request["product_name"];
            p.Price=(int)Double.Parse(Request["product_price"]);
            p.Description = Request["product_description"];
            p.Manufacture =  Convert.ToInt32(Request["product_manufacturer"]);
            p.ProductType = Convert.ToInt32(Request["product_type"]);
            p.SetData();
            return View();
        }

        public ActionResult ListProduct()
        {
            List<OnlineShopingLib.Product> products = OnlineShopingLib.Product.GetData<Product>("","");
            ModelListProduct modelListProduct=new ModelListProduct(products);
            return View(modelListProduct);
        }

        public ActionResult ProductUpdate()
        {
            return View();
        }
    }
}