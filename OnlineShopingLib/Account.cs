using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopingLib
{
    public class Account:ClientObject
    {
        public Account()
        {
            _handle = ClientObjectManager.CreateObject("Accout");
        }

        public Account(int hand):base(hand)
        {

        }
        public int Id
        {
            get
            {
                return Convert.ToInt32(ClientObjectManager.GetAttribute(_handle, "id"));
            }
            set
            {
                ClientObjectManager.SetAttribute(_handle, "id", value.ToString());
            }
        }

        public string UserName
        {
            get
            {
                return ClientObjectManager.GetAttribute(_handle, "username");
            }
            set
            {
                ClientObjectManager.SetAttribute(_handle, "username", value);
            }
        }

        public string Password
        {
            get
            {
                return ClientObjectManager.GetAttribute(_handle, "password");
            }

            set
            {
                ClientObjectManager.SetAttribute(_handle, "password", value);
            }
        }

        public string Email
        {
            get
            {
                return ClientObjectManager.GetAttribute(_handle, "email");
            }

            set
            {
                ClientObjectManager.SetAttribute(_handle, "email", value);
            }
        }

        public string Phone
        {
            get
            {
                return ClientObjectManager.GetAttribute(_handle, "phone");
            }

            set
            {
                ClientObjectManager.SetAttribute(_handle, "phone", value);
            }
        }
        public string Address
        {
            get
            {
                return ClientObjectManager.GetAttribute(_handle, "adress");
            }

            set
            {
                ClientObjectManager.SetAttribute(_handle, "address", value);
            }
        }
        public int AccountType
        {
            get
            {
                return Convert.ToInt32(ClientObjectManager.GetAttribute(_handle, "acctypeId"));
            }

            set
            {
                ClientObjectManager.SetAttribute(_handle, "acctypeId", value.ToString());
            }
        }


    }
}
