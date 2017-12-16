using OnlineShoping.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using OnlineShoping.ServiceReference1;
using OnlineShopingLib;
namespace OnlineShoping.DAO
{
    public class ManufactureDAO
    {
        public List<Manufacture> GetManufactures()
        {
            
            List<Product> p = Product.GetData("", "");
            WebService.WebServiceSoapClient service = new WebService.WebServiceSoapClient();
            DataTable data = new DataTable();
            StringReader reader = new StringReader(service.GetAllManufacturer());
            data.ReadXml(reader);
            List<Manufacture> m = new List<Manufacture>();
            for(int i=0;i< data.Rows.Count; i++)
            {
                Manufacture tmp = new Manufacture();
                tmp.ID = data.Rows[i]["id"].ToString();
                tmp.Name = data.Rows[i]["_name"].ToString();
                
                m.Add(tmp);
            }
            return m;
        } 
    }
}