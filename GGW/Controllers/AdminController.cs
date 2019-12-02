using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GGW.Models;


namespace GGW.Controllers
{
    public class AdminController : Controller
    {
        GGWdbContext db = new GGWdbContext();
        // GET: Admin
        public ActionResult Index()
        {
            var rr = db.adminM.Select(e => e);
            return View(rr);
        }
        public ActionResult insert(string username, string userpwd,adminM MM)
        {
            if (username != null && userpwd != null)
            {
                var name_re = db.adminM.Where(e => e.adminName == username);
                if (name_re.ToList().Count > 0)
                {
                    return Json(new { s = "00" });
                }
                var re = db.adminM.Where(e => e.adminName == username && e.adminPwd == userpwd);
                if (re.ToList().Count > 0)
                {
                    return Json(new { s = "1" });
                }
                else
                {
                    MM.adminName = username.ToString();
                    MM.adminPwd = userpwd.ToString();
                    db.adminM.Add(MM);
                    db.SaveChanges();
                    return Json(new { s = "ok" });
                }
            }
            else
            {
                return Json(new { s = "0" });

            }

        }

        public ActionResult Sel_news()
        {
            var re = db.news.Select(e => e);
            return View(re);
        }
        public ActionResult Edit_news()
        {
            var re = db.news.Select(e=>e);
            return View(re);
        }
        public ActionResult Edit(int id)
        {
            var re = db.news.Find(id);
            return View(re);
        }
        [HttpPost]
        public ActionResult Edit(news nn)
        {
            var re = db.news.Find(nn.id);
            UpdateModel(re);
            db.SaveChanges();
            return RedirectToAction("Edit_news");
        }
        public ActionResult Delete(int id)
        {
            var re = db.news.Find(id);
            db.news.Remove(re);
            db.SaveChanges();
            return RedirectToAction("Edit_news");
        }
        public ActionResult up_news()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult up_news(news nn)
        {
            if (ModelState.IsValid)
            {
                db.news.Add(nn);
                db.SaveChanges();
                return RedirectToAction("Sel_news");

            }
            else
                return View();
        }
    }
}