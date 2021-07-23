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


        public ActionResult Index()
        {
            
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
            ProfileDataModel Pd = new ProfileDataModel();
            List<ProfileDataModel> pdList = new List<ProfileDataModel>();
            pdList.Add(Pd);
            foreach (var var in pdList )
            {
                if (var.UserId == Id)
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