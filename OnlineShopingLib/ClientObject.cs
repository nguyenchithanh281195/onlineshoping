using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace OnlineShopingLib
{
    public class ClientObject
    {
        protected int _handle;


        public ClientObject(int handle)
        {
            _handle = handle;
        }

        protected ClientObject()
        {
            _handle= ClientObjectManager.CreateObject("");
        }

        public void SetData()
        {
            ClientObjectManager.SetData(_handle, this.GetType().Name);
        }

        public static List<T> GetData<T>(string field, string condition)
        {
            List<T> obj = new List<T>();
            try
            {
                List<int> data = ClientObjectManager.GetData(field, typeof(T).Name, condition);

                
                for (int i = 0; i < data.Count; i++)
                {
                    
                    obj.Add((T)Activator.CreateInstance(Type.GetType(typeof(T).FullName),new object[] {data[i]}));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
               
            }

            return obj;
        }

        public virtual void Delete()
        {
            ClientObjectManager.Delete(_handle, this.GetType().Name,"id");
        }

        public void Update()
        {
            ClientObjectManager.Update(_handle, this.GetType().Name, "id");
        }

        ~ClientObject()
        {
            ClientObjectManager.Destroy(_handle);
        }
    }
}

