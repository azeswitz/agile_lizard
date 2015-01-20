using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgileLizard.Site.Controllers
{
    public class SeoController : Controller
    {
        // GET: Seo
        public ActionResult Robots()
        {
            var robotsFile = "~/robots-default.txt";
            return File(robotsFile, "text/plain");
        }
    }
}