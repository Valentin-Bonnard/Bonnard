using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Bonnard.Models;
using System.Threading.Tasks;

namespace Bonnard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Show = true;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = " Young developer with some experience building  websites, HTML5 CSS3 and various web scripting technologies (like Prestashop), web standards."
                + " Well - versed in c#, Dotnet and I am lerning Asp.net technologies, and continue my c#/ ect... upgrading. Also, i am seasonned with project management and agile method."
                + "Enthusiastic web professional motivated by challenging projects and deadlines" ;
            ViewBag.Show = false;
            return View();
        }


        public ActionResult Contact()
        {

            ViewBag.Show = false;
            return View();
        }
        public ActionResult Work_Preview()
        {
            ViewBag.Show = false;
            return View();
        }

        public ActionResult Email()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Email(ContactModel C)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("dev.bonnard@gmail.com"));
                message.Subject = "Contact";
                message.Body = string.Format(body, C._name, C._email, C._subject, C._content);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Success");
                }
            }
            ViewBag.Show = false;
            return View(C);
        }

        public ActionResult Success()
        {
            return View();
        }
    }
}