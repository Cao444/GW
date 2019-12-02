using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GGW.Controllers
{
    public class MyController : Controller
    {
        // GET: My
        public ActionResult Index()
        {
            ViewBag.title = "关于我们";
            return View();
        }
        public ActionResult introduce()
        {
            ViewBag.title = "公司介绍";
            return View();
        }
        public ActionResult culture()
        {
            ViewBag.title = "企业文化";
            return View();
        }
    }
}