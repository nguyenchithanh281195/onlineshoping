﻿using Service.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Service.BUS
{
    public class ObjectBUS
    {
        ObjectDAO obj = new ObjectDAO();
        public DataTable GetManufacturer()
        {
            return obj.GetManufacture();
        }
        public List<String> GetParameter(string product)
        {
            return obj.GetParameter(product);
        }
    }
}