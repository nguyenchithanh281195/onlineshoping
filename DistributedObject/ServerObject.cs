﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using DistributedObject.Service;

namespace DistributedObject
{
    public class ServerObject
    {
       
        private Dictionary<string, Property> properties = new Dictionary<string, Property>();
        public delegate object Method(ServerObject obj, object parameter);
        static Service.WebServiceSoapClient service= new WebServiceSoapClient();
        private Dictionary<string, Method> methods = new Dictionary<string, Method>();
        public string this[string name]
        {
            get
            {
                if (properties.ContainsKey(name))
                {
                    return properties[name].Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (properties.ContainsKey(name))
                {
                    properties[name].Value = value;
                }
                else
                {
                    properties.Add(name, new Property(name, "string", value));
                }
            }
        }

        protected int _handler;
        public ServerObject()
        {
            _handler = WebService.GetNextHandler();
            WebService.Register(this);
        }

        public static List<int> GetDataFromTable(string field,string tableName, string condition)
        {
            DataTable data = new DataTable();
            StringReader reader = new StringReader(service.GetDataFromTable(field, tableName, condition));
            data.ReadXml(reader);
            List<int> m = new List<int>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                m.Add(ConvertToObject(data.Rows[i])); 
            }
            return m;

        }

        private static int ConvertToObject(DataRow dataRow)
        {
            ServerObject s=new ServerObject();
            for (int i = 0; i < dataRow.Table.Columns.Count; i++)
            {
                s[dataRow.Table.Columns[i].ColumnName]=dataRow[i].ToString();
            }
            return s._handler;
        }
    }
}