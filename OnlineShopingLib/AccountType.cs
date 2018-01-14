using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopingLib
{
    public class AccountType: ClientObject
    {
        public AccountType()
        {
            ClientObjectManager.CreateObject("AccountType");
        }
        public AccountType(int hand) : base(hand) { }
        public int Id
        {
            get
            {
                return Convert.ToInt32(ClientObjectManager.GetAttribute(_handle,"id"));
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

    }
}
