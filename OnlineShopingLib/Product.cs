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
       

        public Product()
        {
            
        }

        public Product(int handle):base(handle)
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

        public int Manufacture
        {
            get { return Int32.Parse(ClientObjectManager.GetAttribute(_handle, "manufacturer")); }
            set { ClientObjectManager.SetAttribute(_handle, "manufacturer", value.ToString()); }
        }

        public int ProductType
        {
            get { return Int32.Parse(ClientObjectManager.GetAttribute(_handle, "producttype"));}
            set { ClientObjectManager.SetAttribute(_handle, "producttype", value.ToString()); }
        }


        
    }
}