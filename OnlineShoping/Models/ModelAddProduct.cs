using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineShopingLib;

namespace OnlineShoping.Models
{
    public class ModelAddProduct
    {
       

        public ModelAddProduct(List<ProductType> catergories, List<Manufacturer> m)
        {
            this.Types = catergories;
            this.Manufacturers = m;
        }

        public Product Product1 { get; set; }
        public List<ProductType> Types { get; set; }
        public List<Manufacturer> Manufacturers { get; set; }
    }
}