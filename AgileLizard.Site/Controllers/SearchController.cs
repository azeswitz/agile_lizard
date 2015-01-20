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
    public class SearchController : Controller
    {

        private IProcurementManager _pMgr;
        private IDocumentManager _docMgr;
        private IFactManager _factMgr;
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public SearchController(IProcurementManager pMgr, IDocumentManager docMgr, IFactManager factMgr)
        {
            this._pMgr = pMgr;
            this._docMgr = docMgr;
            this._factMgr = factMgr;
        }

        public ActionResult Index()
        {
            return RedirectToAction("Results");
        }
        // GET: Search
        [HttpGet]
        public ActionResult Results()
        {
            SearchViewModel model = new SearchViewModel();
            model.FactRequestTypeList = _factMgr.GetFactTypeList();
            model.FactSetAsideList = _factMgr.GetSetAsideList();
            if (!String.IsNullOrEmpty(Request.Params["q"]))
            {
                model.Params = HttpUtility.HtmlEncode(Request.Params["q"]);
                try
                {
                    model.StartingRecord = Int32.Parse(HttpUtility.HtmlEncode(Request.Params["s"]));
                }
                catch (Exception ex)
                {
                    model.StartingRecord = 1;
                    //stuff exception - only really care if it is an int..
                }
                IList<Doc> results = _docMgr.GetRecords(model.Params, model.StartingRecord);
                model.FboDocs = Mapper.Map<IList<Doc>, IList<FbOpenDocumentViewModel>>(results);
                return View(model);
            }
            return View();

        }

        [HttpPost]
        public ActionResult Results(SearchViewModel model)
        {
            model.FactRequestTypeList = _factMgr.GetFactTypeList();
            model.FactSetAsideList = _factMgr.GetSetAsideList();
            IList<Doc> results = _docMgr.GetRecords(model.Params);
            model.FboDocs = Mapper.Map<IList<Doc>, IList<FbOpenDocumentViewModel>>(results);
            return View(model);
        }

        public ActionResult Wizard()
        {
            return View();
        }

    }
}