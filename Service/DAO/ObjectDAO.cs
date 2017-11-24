using Service.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Service.DTO
{
    public class ObjectDAO
    {
        public DataTable GetManufacture()
        {
            return Provider.ExecuteQuery("Select* from Manufacturer");
        }

        internal List<string> GetParameter(string product)
        {
            return null;
        }
    }
}