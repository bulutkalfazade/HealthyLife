using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BitirmeProjesi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
       // Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
    }
}