using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApplication2.Controllers
{
    
    public class HomeController : Controller
    {
        bool flag = false;
        public ActionResult Index()
        {
            ViewBag.flagvalue = flag;
            return View();
        }
        [HttpPost]
     
        public ActionResult About(FormCollection frm)
        {
            flag = true;
            ViewBag.flagvalue = flag;
            ViewBag.Name = frm["name"].ToString();
            ViewBag.Addr = frm["addr"].ToString();
            return View();
        }

     


    }
}