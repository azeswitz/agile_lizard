using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Reflection;

using AgileLizard.Business.Interfaces;
using AgileLizard.Business.Dto;
using AgileLizard.Fbopen.Client.Interfaces;
using AgileLizard.Fbopen.Client.Dto;

using AgileLizard.Site.Models;
using AutoMapper;
using log4net;


namespace AgileLizard.Site.Controllers
{
    public class ProfileController : Controller
    {

        private IFboProfileManager _profileMgr;
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public  ProfileController (IFboProfileManager profileMgr)
        {
            this._profileMgr = profileMgr;
        }
        // GET: Profile
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit(string id)
        {
            FboProfileDto p = _profileMgr.GetById(Guid.Parse(id));
            FboProfileViewModel model = Mapper.Map<FboProfileViewModel>(p);
            return View(model);
        }

        public ActionResult Public(string id)
        {
            FboProfileDto p = _profileMgr.GetById(Guid.Parse(id));
            FboProfileViewModel model = Mapper.Map<FboProfileViewModel>(p);
            return View(model);
        }
    }
}