using AgileLizard.Business.Dto;
using AgileLizard.Business.Interfaces;
using AgileLizard.Fbopen.Client.Dto;
using AgileLizard.Fbopen.Client.Interfaces;
using AgileLizard.Site.Models;
using AutoMapper;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace AgileLizard.Site.Controllers
{
    public class UtilityController : Controller
    {
        private IProcurementManager _pMgr;
        private IDocumentManager _docMgr;
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public UtilityController(IProcurementManager pMgr, IDocumentManager docMgr)
        {
            this._pMgr = pMgr;
            this._docMgr = docMgr;
        }
        // GET: Utility
        public ActionResult Index()
        {

            XmlDocument xdcDocument = new XmlDocument();

            xdcDocument.Load(@"C:\temp\FBOFullXML.xml");

            XmlElement xelRoot = xdcDocument.DocumentElement;
            XmlNodeList xnlNodes = xelRoot.SelectNodes("/NOTICES/COMBINE");

            foreach (XmlNode xndNode in xnlNodes)
            {
                //What to write here??
                //My sql insert command will go here
            }

            return View();
        }

        public ActionResult LoadFromFbo()
        {
            string[] searchVars = new string[] {
                "SQL Server",
                "Software Development",

            };
            int increment = 10;
            int total = 100;
            for (int a = 0; a < searchVars.Length; a++)
            {
                SearchViewModel model = new SearchViewModel();
                model.StartingRecord = 0;
                model.Params = searchVars[a];
                while (model.StartingRecord < total)
                {
                    IList<Doc> results = _docMgr.GetRecords(model.Params, model.StartingRecord);
                    model.FboDocs = Mapper.Map<IList<Doc>, IList<FbOpenDocumentViewModel>>(results);
                    foreach (FbOpenDocumentViewModel doc in model.FboDocs)
                    {
                        ProcurementDto localDoc = Mapper.Map<FbOpenDocumentViewModel, ProcurementDto>(doc);
                        _pMgr.SaveOrUpdate(localDoc);
                    }
                    model.StartingRecord = model.StartingRecord + increment;
                }



            }
            return View();
        }
    }


}