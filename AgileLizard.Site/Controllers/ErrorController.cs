﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgileLizard.Site.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult GenericError()
        {
            return View("Error");
        }
    }
}