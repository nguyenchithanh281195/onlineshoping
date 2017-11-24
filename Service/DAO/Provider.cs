using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Service.DAO
{
    public class Provider
    {
        static SqlConnection _Connect;

        public Provider()
        {
            _Connect = new SqlConnection(@"Server=tcp:ktpm.database.windows.net,1433;Initial Catalog=KTPM;Persist Security Info=False;User ID=shopingonline;Password=Thanh2018;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        public static DataTable ExecuteQuery(string strQuery)
        {
            _Connect = new SqlConnection(@"Server=tcp:ktpm.database.windows.net,1433;Initial Catalog=KTPM;Persist Security Info=False;User ID=shopingonline;Password=Thanh2018;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            DataTable table = new DataTable();

            try
            {
                _Connect.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(strQuery, _Connect);

                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                throw new Exception("Loi khi thuc thi: " + ex.Message);
            }
            finally
            {
                _Connect.Close();
            }

            return table;
        }

    }
}
