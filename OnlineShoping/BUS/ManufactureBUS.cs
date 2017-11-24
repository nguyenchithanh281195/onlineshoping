using OnlineShoping.DAO;
using OnlineShoping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoping.BUS
{
    public class ManufactureBUS
    {
        ManufactureDAO dao = new ManufactureDAO();
        public List<Manufacture> GetManufactures()
        {
            return dao.GetManufactures();
        }
    }
}