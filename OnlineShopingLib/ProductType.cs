using System;

namespace OnlineShopingLib
{
    public class ProductType: ClientObject
    {
        public int Id
        {
            get { return Int32.Parse(ClientObjectManager.GetAttribute(_handle, "id")); }
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
    }
}