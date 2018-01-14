using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using OnlineShopingLib;
namespace MessageCenter
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
        [WebMethod]
        public void SubcribePage(int id)
        {
            Subscribes s = new Subscribes();
            s.AccountId = id;
            s.SetData();
        }

        [WebMethod]
        public void Notify(string message)
        {
            List<Account> subs = Account.GetData<Account>("", "id in (select Subscribes.accId from Subscribes)");
            foreach(Account acc in subs)
            {
                MailManagement.SendMail(acc.Email, "New Product", message);
            }
        }
    }
}
