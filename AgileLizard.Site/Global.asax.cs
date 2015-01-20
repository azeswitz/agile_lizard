using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Http;
using log4net;
using System.Reflection;
using AgileLizard.Site.Controllers;

namespace AgileLizard.Site
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        protected void Application_Start()
        {

            log4net.Config.XmlConfigurator.Configure();
            AreaRegistration.RegisterAllAreas();

            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMapperConfig.Init();
        }

        protected void Application_Error()
        {
            Exception exception = Server.GetLastError();
            HttpException httpException = exception as HttpException;

            var code = httpException == null ? 500 : httpException.GetHttpCode();
            // Log the exception.
            log.Error(exception);

            Server.ClearError();
            RouteData routeData = new RouteData();
            routeData.Values.Add("controller", "Error");
            routeData.Values.Add("action", "GenericError");

            IController errorController = new ErrorController();
            errorController.Execute(new RequestContext(new HttpContextWrapper(Context), routeData));

        }
    }
}
