using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Bolnica.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Message = "Your service page.";

            return View();
        }

        public ActionResult Schedule()
        {
            ViewBag.Message = "Your service page.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Doctors() {
            return View();
        }
        
        [HttpPost]
        public ActionResult CallBackResult(FormCollection submit)
        {
            StringBuilder sb = new StringBuilder();
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("E:\\res.txt")) {
                file.WriteLine(submit["email"]);
            }
            ViewBag.Result = "success";
            return View(); 
        }



        public ActionResult CallBack() {
            return View();
        }
    }
}
