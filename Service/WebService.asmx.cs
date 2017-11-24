using Service.BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Service
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        ObjectBUS bus = new ObjectBUS();
        [WebMethod] //truoc moi ham can khai bao webmethod de ben ngoai co the goi duoc
        public string GetAllManufacturer() // sau do viet ham nhu binh thuowng
        {
            StringWriter sw = new StringWriter();
            DataTable data = bus.GetManufacturer();
            data.TableName = "Manufacturer";
            data.WriteXml(sw, XmlWriteMode.WriteSchema);
            string result = sw.ToString();
            return result;
        }
    }
}
