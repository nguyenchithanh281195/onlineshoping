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

        public DataTable GetAllProducts()
        {
            return Provider.ExecuteQuery("Select* from Product");
        }

        public DataTable GetDataFromTable(string field, string tableName, string condition)
        {
            
            if (field == "")
            {
                field = "*";
            }
            string s = String.Format("Select {0} from {1} where {2})", field, tableName, condition);
            if (condition == "")
            {
                s = String.Format("Select {0} from {1}", field, tableName);
            }

            return Provider.ExecuteQuery(s);
        }
    }
}