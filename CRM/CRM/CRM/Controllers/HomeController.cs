using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using CRM.Models;

namespace CRM.Controllers
{
    public class HomeController : Controller
    {

        List<Profile> pr = new List<Profile>()
        {
            new Profile() {Id = 1, Fname = "KAran", Lname = "Padhya", Phonenumber = 226, Emailaddress = "Emailadress"},
            new Profile() {Id = 2, Fname = "Dhruvin", Lname = "kanani", Phonenumber = 226, Emailaddress = "Emailadress"},
            new Profile() {Id = 3, Fname = "xyz", Lname = "abc", Phonenumber = 226, Emailaddress = "Emailadress"},
            new Profile() {Id = 4, Fname = "pqr", Lname = "svasd", Phonenumber = 226, Emailaddress = "Emailadress"}

        };

        public ActionResult Index()
        {
            ViewBag.data1 = pr;
            return View();
        }

        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            Thread.CurrentThread.CurrentCulture = Session["Language"] != null
                ? (Thread.CurrentThread.CurrentUICulture = (CultureInfo)Session["Language"])
                : (Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US"));
            return base.BeginExecuteCore(callback, state);
        }

        public ActionResult Language(string culture)
        {
            var lang = new CultureInfo(culture);
            Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = lang;
            Session["Language"] = lang;

            if (!(Request.UrlReferrer is null)) return Redirect(Request.UrlReferrer.ToString());
            return RedirectToAction("index");

        }
        public ActionResult Edit(int Id=1)
        {
            
            foreach (var var in pr)
            {
                if (var.Id == Id)
                {
                    return View(var);// matching the data coming from id to the viewbag data
                }
            }

            return View();
        }


        public ActionResult Delete(int Id)
        {

           

            return Index();
        }

        public ActionResult Newuser()
        {
           
            return View();
        }

    }
}