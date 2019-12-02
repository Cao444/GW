using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GGW.Models;

namespace GGW.Controllers
{
    public class NewsController : Controller
    {
        GGWdbContext db = new GGWdbContext();
        // GET: News
        public ActionResult Index()
        {
            ViewBag.title = "新闻中心";
            var c = db.news.Select(e => e);
            return View(c);
        }
    }
}