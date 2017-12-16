using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopingLib.ServiceReference1;

namespace OnlineShopingLib
{
    public class Product : ClientObject
    {
        private Manufature manufacture;
        private ProductType productType;

        public Product()
        {
            ClientObjectManager.CreateObject("Product");
        }

        private Product(int handle):base(handle)
        {
            
        }
        public int Id
        {
            get
            {
                return Int32.Parse(ClientObjectManager.GetAttribute(_handle, "id"));
            }
            set
            {
                ClientObjectManager.SetAttribute(_handle, "id", value.ToString());
            }
        }

        public string Name
        {
            get
            {
                return ClientObjectManager.GetAttribute(_handle, "name");
            }
            set
            {
                ClientObjectManager.SetAttribute(_handle, "name", value);
            }
        }

        public int Price
        {
            get
            {
                return Convert.ToInt32(ClientObjectManager.GetAttribute(_handle, "price"));
            }
            set
            {
                ClientObjectManager.SetAttribute(_handle, "price", value.ToString());
            }
        }

        public string TechnicalParameter
        {
            get
            {
                return ClientObjectManager.GetAttribute(_handle, "technicalparameter");
            }
            set
            {
                ClientObjectManager.SetAttribute(_handle, "technicalparameter", value);
            }
        }

        public string Description
        {
            get
            {
                return ClientObjectManager.GetAttribute(_handle, "description");
            }
            set
            {
                ClientObjectManager.SetAttribute(_handle, "description", value);
            }
        }

        public Manufature Manufacture
        {
            get
            {
                return manufacture;
            }
            set
            {
                manufacture=value;
            }
        }

        public ProductType ProductType
        {
            get { return productType; }
            set { productType = value; }
        }


        public static List<Product> GetData(string field, string condition)
        {
            ServiceReference1.WebServiceSoapClient abc=new WebServiceSoapClient();
            List<Product> obj=new List<Product>();
            try
            {
                
                List<int> data = ClientObjectManager.GetData(field, "Product", condition);

                for (int i = 0; i < data.Count; i++)
                {
                    obj.Add(new Product(data[i]));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
           
            return obj;
        }
    }
}