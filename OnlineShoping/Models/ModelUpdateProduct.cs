using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineShopingLib;

namespace OnlineShoping.Models
{
    public class ModelUpdateProduct
    {
        public Product Product1 { get; set; }
        public ProductType ProductType1 { get; }
        public Manufacturer Manufacturer1 { get; }

        public ModelUpdateProduct(int id)
        {
            Product1 = Product.GetData<Product>("", "id = " + id.ToString())[0];
            ProductType1 = ProductType.GetData<ProductType>("", "id=" + Product1.ProductType.ToString())[0];
            Manufacturer1 = Manufacturer.GetData<Manufacturer>("", "id=" + Product1.Manufacture)[0];
        }
    }
}