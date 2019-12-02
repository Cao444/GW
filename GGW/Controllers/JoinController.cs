using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GGW.Controllers
{
    public class JoinController : Controller
    {
        // GET: Join
        public ActionResult Index()
        {
            ViewBag.title = "招商加盟";
            return View();
        }
    }
}