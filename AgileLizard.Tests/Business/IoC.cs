using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using log4net;
using StructureMap;
using AgileLizard.Domain;
using AgileLizard.Data.Interfaces;
using AgileLizard.Data.Repositories;
using AgileLizard.Business.Interfaces;
using AgileLizard.Business.Managers;
using AgileLizard.Fbopen.Client.Interfaces;
using AgileLizard.Fbopen.Client.Managers;

namespace AgileLizard.Tests.Business
{
    public class IoC
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        [TestMethod]
        public static void Init()
        {
            log4net.Config.XmlConfigurator.Configure();
            ObjectFactory.Configure(x =>
            {
                x.For<System.Data.Entity.DbContext>().Singleton().Use<AgileLizard.Data.Entities>();
                x.For<IGenericDataRepository<Demo>>().Use<GenericDataRepository<Demo>>();
                x.For<IGenericDataRepository<Procurement>>().Use<GenericDataRepository<Procurement>>();
                x.For<IGenericDataRepository<FboProfile>>().Use<GenericDataRepository<FboProfile>>();
                x.For<IGenericDataRepository<FactRequestType>>().Use<GenericDataRepository<FactRequestType>>();
                x.For<IGenericDataRepository<FactSetAside>>().Use<GenericDataRepository<FactSetAside>>();

                x.For<IProcurementManager>().Use<ProcurementManager>();
                x.For<IFboProfileManager>().Use<FboProfileManager>();

                x.For<IFactManager>().Use<FactManager>();

                //FBOpen Client
                x.For<IDocumentManager>().Use<DocumentManager>();


            });
        }
    }
}
