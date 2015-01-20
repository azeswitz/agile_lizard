using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Reflection;
using AgileLizard.Business;
using AgileLizard.Business.Dto;
using AgileLizard.Business.Interfaces;
using log4net;

namespace AgileLizard.Site.Controllers
{
    public class ProcurementInfoApiController : ApiController
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        IProcurementManager _mgr;

        public ProcurementInfoApiController(IProcurementManager mgr)
        {
            this._mgr = mgr;
        }

        [HttpGet]
        public ProcurementDto Get(int id=0)
        {
            ProcurementDto p;
            if (id > 0)
                p = this._mgr.GetById(id);
            else
                p = new ProcurementDto();

            return p;
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody]ProcurementDto p)
        {
            try
            {
                ProcurementDto x = this._mgr.SaveOrUpdate(p);
                return Request.CreateResponse(HttpStatusCode.Created, x);
            }
            catch(Exception ex)
            {
                log.Error(ex);
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
           
        }
    }
}
