using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GGW.Models;

namespace GGW.Controllers
{
    public class HomeController : Controller
    {
        GGWdbContext db = new GGWdbContext();
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.title = "首页";
            var img = db.II.Select(e => e);
            return View(img);
        }
    }
}