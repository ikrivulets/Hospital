using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Net.Mail;
using System.Web.Mvc;
using System.Net;

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
            ViewBag.Message = "Your schedule.";

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
<<<<<<< HEAD
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("E:\\res.txt")) {
                file.WriteLine(submit["email"]);
            }
            try
            {
                SendEmail(submit["text"], submit["email"], "matvei.nazaruk@gmail.com", "callback", submit["fio"]);

                ViewBag.Result = "success";
            }
            catch
            {
                ViewBag.Result = "failed";

            }
=======
            ViewBag.Result = "success";
>>>>>>> 1fc643646388f0271191f1c873873263d24ecbe1
            return View(); 
        }



        public ActionResult CallBack() {
            return View();
        }

        public void SendEmail(string msgBody, string sendTo, string sendFrom, string subject, string toName)
        {
            var fromAddress = new MailAddress(sendFrom, toName);
            var toAddress = new MailAddress(sendFrom, "Sviclochskaya central'naya gorodskaya bolnica");
            const string fromPassword = "6092726moiNOMER*";
            string body = msgBody + " My mail: " + sendTo;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 20000
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
