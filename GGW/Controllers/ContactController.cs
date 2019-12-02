using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GGW.Controllers
{
    public class ContactController : Controller
    {
        private string aa = "";//用来存放feedback传回的值
        private string bb = "";//用来存放admin传回的值
        private string cc = "有什么要服务的吗？？？";

        public string Aa { get => aa; set => aa = value; }
        public string Bb { get => bb; set => bb = value; }
        public string Cc { get => cc; set => cc = value; }

        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.title = "联系我们";
            return View();
        }
        public ActionResult feedback()
        {
            ViewBag.title = "在线联系客服";
            return View();
        }
        public ActionResult admin()
        {
            ViewBag.title = "管理员回答";
            return View();
        }
        public ActionResult show(string zz)
        {
            return Content(Cc);
        }
        /// <summary>
        /// feedback页接收器
        /// </summary>
        /// <param name="NR"></param>
        /// <returns></returns>
        public ActionResult Chuan(string NR)
        {
            if (NR.Equals(""))
            {
                return Content("请先输入要咨询的问题！！");
            }
            else
            {
                aa += NR.ToString();
                if (bb.Equals(""))
                {
                    return Content("人工服务繁忙！请稍后");
                }
                else
                {
                    return Content(Bb);
                }
            }
        }
    }
}