using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopingLib
{
    public class ClientObject
    {
        protected int _handle;

        
        protected ClientObject(int handle)
        {
            _handle = handle;
        }

        protected ClientObject()
        {
            
        }

        public void SetData()
        {
            ClientObjectManager.SetData(_handle,this.GetType().Name.ToLower());
        }
    }
}
