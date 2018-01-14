using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopingLib
{
    public class Subscribes:ClientObject
    {
        public Subscribes()
        {
            ClientObjectManager.CreateObject("Subcriber");
        }
        public Subscribes(int hand) : base(hand) { }
        public int AccountId
        {
            get
            {
                return Convert.ToInt32(ClientObjectManager.GetAttribute(_handle, "accId"));
            }
            set
            {
                ClientObjectManager.SetAttribute(_handle, "accId", value.ToString());
            }
                
        }
        public override void Delete()
        {
            ClientObjectManager.Delete(_handle, this.GetType().Name, "accId");
        }
    }
}
