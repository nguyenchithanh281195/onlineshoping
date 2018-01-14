using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineShopingLib;

namespace OnlineShoping.Models
{
    public class ModelCheckout
    {
        public Dictionary<string,string> Amount { get; set; }
        public List<Product> Product { get; set; }
        
    }
    public class ModelListProduct
    {
        public List<Product> Products { get; set; }
        public List<ProductType> ProductTypes { get; set; }
        public List<Manufacturer> Manufacturers { get; set; }
        public ModelListProduct()
        {
            Products=new List<Product>();
            ProductTypes = ProductType.GetData<ProductType>("", "");
            for (int i = 0; i < ProductTypes.Count; i++)
            {
                List<Product> products = Product.GetData<Product>("top 3 *", "producttype = " + ProductTypes[i].Id);
                Products.AddRange(products);
            }
            Manufacturers = Manufacturer.GetData<Manufacturer>("", "");

        }

        public ModelListProduct(List<Product> p)
        {
            Products = p;
        }
    }
}