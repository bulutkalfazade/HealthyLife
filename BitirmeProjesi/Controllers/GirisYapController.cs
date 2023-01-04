using BitirmeProjesi.Models.AllClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BitirmeProjesi.Controllers
{
    public class GirisYapController : Controller
    {
        // GET: GirisYap
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin admin )
        {
            var bilgiler = c.Admins.FirstOrDefault(x=>x.User == admin.User 
            && x.Password == admin.Password);
            
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.User, false);
                Session["User"] = bilgiler.User.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }
    }
}