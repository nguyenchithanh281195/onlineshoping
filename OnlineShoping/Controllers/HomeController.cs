using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using OnlineShoping.Models;
using OnlineShopingLib;

namespace OnlineShoping.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            ModelListProduct p=new ModelListProduct();
            return View(p);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Product()
        {
            var type = Int32.Parse(Request.QueryString["type"]);
            var page = Int32.Parse(Request.QueryString["page"]);
            var manufacturer= Int32.Parse(Request.QueryString["manufacturer"]);
            var price= Int32.Parse(Request.QueryString["price"]);
            var where = "";
            if (manufacturer != -1)
            {
                where += "manufacturer=" + manufacturer;
            }
            if (type != -1)
            {
                if (where != "") {
                    where += " and ";
                }
                where += "producttype=" + type;
            }
     
            if (price != -1)
            {
                if (where != "")
                {
                    where += " and ";
                }
                switch (price)
                {
                    case 1: where += "price<100";break;
                    case 2: where += "price>=100 and price<1000";break;
                    case 3: where += "price>=1000 and price<=10000";break;
                    case 4: where += "price>=10000";break;
                }
            }
            List<Product> p = OnlineShopingLib.Product.GetData<Product>("", where+" order by id offset "+ page*3 + "ROWS FETCH NEXT 3 ROWS ONLY");
            var jsonSerialiser = new JavaScriptSerializer();
            var json = jsonSerialiser.Serialize(p);
            return Json(json, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Subcriber()
        {
            int count = Subscribes.GetData<Subscribes>("", "").Count;
            return Json(count.ToString(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Checkout()
        {
            string[] ids = Request["id"].Split(',');
            string[] amount = Request["quantity"].Split(',');
            Dictionary<string, string> amounts = new Dictionary<string, string>();
            for(int i=0;i< amount.Length;i++)
            {
                amounts.Add(ids[i], amount[i]);
            }


            List<Product> p = OnlineShopingLib.Product.GetData<Product>("", "id in(" + Request["id"] + ")");
            ModelCheckout m = new ModelCheckout();
            m.Amount = amounts;
            m.Product = p;
            
            return View(m);
        }

    }
}