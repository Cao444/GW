using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GGW.Models;

namespace GGW.Controllers
{
    public class Admin_EditController : Controller
    {
        GGWdbContext db = new GGWdbContext();
        // GET: Admin_Edit
        public ActionResult Index()
        {
            var re = db.adminM.Select(e => e);
            return View(re);
        }
        public ActionResult Edit(int id)
        {
            var re = db.adminM.Find(id);
            return View(re);
        }
        [HttpPost]
        public ActionResult Edit(adminM MM)
        {
            var re = db.adminM.Find(MM.adminID);
            UpdateModel(re);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var re = db.adminM.Find(id);
            db.adminM.Remove(re);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}