using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopingLib.WebService;


namespace OnlineShopingLib
{
    class ClientObjectManager
    {
        public static WebService.WebServiceSoapClient serverObjectManager = new WebServiceSoapClient();

        internal static int CreateObject(string v)
        {
            
            return serverObjectManager.RemoteCreateObject(v);
        }

        internal static string GetAttribute(int _handle, string v)
        {
            return serverObjectManager.GetAttribute(_handle, v);
        }

        internal static void SetAttribute(int _handle, string v, string value)
        {
            serverObjectManager.SetAttribute(_handle, v, value);
        }

        public static List<int> GetData(string field, string tableName, string condition)
        {
            return serverObjectManager.GetData(field, tableName, condition);
        }

        public static void SetData(int handle,string tableName)
        {
            serverObjectManager.SetData(handle,tableName);
        }

        public static void Delete(int handle, string name, string id)
        {
            serverObjectManager.Delete(handle,name,id);
        }

        public static void Update(int handle, string tableName, string condition)
        {
            serverObjectManager.Update(handle,tableName,condition);
        }

        internal static void Destroy(int handle)
        {
            serverObjectManager.DestroyObject(handle);
        }
    }
}
