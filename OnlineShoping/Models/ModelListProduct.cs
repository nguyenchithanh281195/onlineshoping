using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineShopingLib;

namespace OnlineShoping.Models
{
    public class ModelListProduct
    {
        public List<Product> Products { get; set; }

        public ModelListProduct(List<Product> products)
        {
            Products = products;
        }
    }
}