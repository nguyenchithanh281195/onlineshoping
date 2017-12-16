using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopingLib.ServiceReference1;


namespace OnlineShopingLib
{
    class ClientObjectManager
    {
        
        
        internal static int CreateObject(string v)
        {
            ServiceReference1.WebServiceSoapClient serverObjectManager = new WebServiceSoapClient();
            return serverObjectManager.RemoteCreateObject(v);
        }

        internal static string GetAttribute(int _handle, string v)
        {
            ServiceReference1.WebServiceSoapClient serverObjectManager = new WebServiceSoapClient();
            return serverObjectManager.GetAttribute(_handle, v);
            ;
        }

        internal static void SetAttribute(int _handle, string v, string value)
        {
            ServiceReference1.WebServiceSoapClient serverObjectManager = new WebServiceSoapClient();
            serverObjectManager.SetAttribute(_handle, v, value);
        }

        public static List<int> GetData(string field, string tableName, string condition)
        {
            ServiceReference1.WebServiceSoapClient serverObjectManager = new WebServiceSoapClient();
            return serverObjectManager.GetData(field, tableName, condition);
        }
    }
}
