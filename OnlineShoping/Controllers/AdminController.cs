using OnlineShoping.BUS;
using OnlineShoping.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShopingLib;

namespace OnlineShoping.Controllers
{
    [Authorize(Roles ="Admin")]
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
            manufacturers = Manufacturer.GetData<Manufacturer>("","");
            ModelAddProduct model = new ModelAddProduct(catergories, manufacturers);
            return View(model);
        }

        [HttpPost]
        public ActionResult AddProductSubmit(FormCollection fc,HttpPostedFileBase file)
        {
            OnlineShopingLib.Product p=new Product();
            p.Name = Request["product_name"];
            p.Price=(int)Double.Parse(Request["product_price"]);
            p.Description = Request["product_description"];
            p.TechnicalParameter = Request["product_technical_parameter"];
            p.Manufacture =  Convert.ToInt32(Request["product_manufacturer"]);
            p.ProductType = Convert.ToInt32(Request["product_type"]);
            

            if (file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/Image"), p.Name+Path.GetExtension(fileName));
                file.SaveAs(path);
                p.Image = "\\Content\\Image\\"+p.Name + Path.GetExtension(fileName);
            }
            p.SetData();
            MessageCenter.WebServiceSoapClient message = new MessageCenter.WebServiceSoapClient();
            message.Notify("Cửa hàng chúng tôi vừa mới nhập sản phẩm " + p.Name + " bạn có thể truy cập vào trang web đề xem chi tiết");
            return Redirect("/Admin/ListProduct");
        }

        public ActionResult ListProduct()
        {
            List<OnlineShopingLib.Product> products = OnlineShopingLib.Product.GetData<Product>("","");
            ModelListProduct modelListProduct=new ModelListProduct(products);
            return View(modelListProduct);
        }

        public ActionResult DeleteProduct()
        {
            Product p = new Product();
            p.Id = Convert.ToInt32(Request.QueryString[0]);
            p.Delete();
            return Redirect("/Admin/ListProduct");
        }

        public ActionResult UpdateProduct()
        {
            ModelUpdateProduct model=new  ModelUpdateProduct(Convert.ToInt32(Request.QueryString[0]));
            return View(model);
        }

        [HttpPost]
        public ActionResult UpdateProductSubmit()
        {
            OnlineShopingLib.Product p = new Product();
            p.Id=Convert.ToInt32(Request["product_id"]);
            p.Name = Request["product_name"];
            p.Price = (int)Double.Parse(Request["product_price"]);
            p.Description = Request["product_description"];
            p.TechnicalParameter = Request["product_technical_parameter"];
            p.Manufacture = Convert.ToInt32(Request["product_manufacturer"]);
            p.ProductType = Convert.ToInt32(Request["product_type"]);
            p.Image = Request["product_image"];
            
  
            p.Update();
            return View();
        }
    }
}