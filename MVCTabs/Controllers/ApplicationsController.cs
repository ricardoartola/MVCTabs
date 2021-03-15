using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTabs.Controllers
{
    public class ApplicationsController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PersonalInfo()
        {
            return View();
        }

        public ActionResult EducationDetails()
        {
            return View();
        }

        public ActionResult EnclosedDocuments()
        {
            return View();
        }
    }
}