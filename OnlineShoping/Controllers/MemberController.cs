
using OnlineShopingLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace OnlineShoping.Controllers
{
    [Authorize(Roles = "Member"+","+"Admin")]
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Subcribe()
        {
            
            string username = User.Identity.Name;
            Subscribes sub = new Subscribes();
            sub.AccountId = Convert.ToInt32(username);
            sub.SetData();
            return Json("true", JsonRequestBehavior.AllowGet);
        }

        public ActionResult Unsubcribe()
        {
            string username = User.Identity.Name;
            Subscribes sub = new Subscribes();
            sub.AccountId = Convert.ToInt32(username);
            sub.Delete();
            return Json("true", JsonRequestBehavior.AllowGet);
        }




        public ActionResult Subscribed()
        {
            int count = Subscribes.GetData<Subscribes>("", String.Format("accId={0}", User.Identity.Name)).Count;
            if (count != 0)
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            return Json(false, JsonRequestBehavior.AllowGet);
        }
    }
}