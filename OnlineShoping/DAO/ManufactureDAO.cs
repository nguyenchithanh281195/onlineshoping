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
        public List<OnlineShopingLib.Manufacturer> GetManufactures()
        {
            WebService.WebServiceSoapClient service = new WebService.WebServiceSoapClient();

        
            List<Manufacturer> m = Manufacturer.GetData<Manufacturer>("", "");
            
            return m;
        } 
    }
}