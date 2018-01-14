using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace DistributedObject
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        private static int _available = 0;
        private static Dictionary<int, ServerObject> _objects = new Dictionary<int, ServerObject>();

        [WebMethod]
        public int RemoteCreateObject(string name)
        {
            if (CreateObject(name) != null)
            {
                return _available;
            }
            else
            {
                return 0;
            }
        }

        [WebMethod]
        public bool DestroyObject(int handle)
        {
            try
            {
                _objects.Remove(handle);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal static int GetNextHandler()
        {
            return ++_available;
        }

        internal static void Register(ServerObject serverObject)
        {
            _objects.Add(_available, serverObject);
        }



        private static ServerObject CreateObject(string name)
        {
            return new ServerObject();
        }

        

        [WebMethod]
        public string GetAttribute(int handle, string attr)
        {
            try
            {
                ServerObject obj = _objects[handle];
                return obj[attr];
            }
            catch (Exception)
            {
                return "";
            }

        }

        [WebMethod]
        public bool SetAttribute(int handle, string attr, string value)
        {
            try
            {
                ServerObject obj = _objects[handle];
                obj[attr] = value;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod]
        public List<int> GetData(string field, string tableName, string condition)
        {
            return ServerObject.GetDataFromTable(field, tableName, condition);
        }

        [WebMethod]
        public void SetData(int handle, string tableName)
        {
            _objects[handle].SetData(tableName);
        }

        [WebMethod]

        public void Delete(int handle, string tableName, string attr)
        {
            try
            {
                _objects[handle].DeleteByAttributeValue(tableName, attr);
                _objects.Remove(handle);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        [WebMethod]
        public void Update(int handle, string tableName, string condition)
        {
            _objects[handle].UpdateData(tableName, condition);
        }

        [WebMethod]
        public int Count()
        {
            return _objects.Count;
        }
    }
}
