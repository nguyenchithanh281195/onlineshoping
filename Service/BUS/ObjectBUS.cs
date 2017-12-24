using Service.DTO;
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

        public DataTable GetAllProducts()
        {
            return obj.GetAllProducts();
        }

        public DataTable GetDataFromTable(string field,string tableName, string condition)
        {
            return obj.GetDataFromTable(field,tableName,condition);
        }

        public void SetData(string tableName, string attr, string value)
        {
            obj.SetDataToTable(tableName, attr, value);
        }

        public void DeleteFromTable(string tableName, string condition)
        {
            obj.DeleteFromTable(tableName, condition);
        }

        public void UpdateData(string tableName, string updateStatement, string condition){
            obj.UpdateData(tableName, updateStatement, condition);
        }
    }
}