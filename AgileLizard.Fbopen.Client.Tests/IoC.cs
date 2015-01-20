using System;
using System.Configuration;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StructureMap;
using StructureMap.Exceptions;
using System.Collections.Generic;
using log4net;
using System.Reflection;

namespace AgileLizard.Fbopen.Client.Tests
{
    [TestClass]
    public class IoC
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        [TestMethod]
        public static void Init()
        {
            log4net.Config.XmlConfigurator.Configure();
            ObjectFactory.Configure(x =>
            {
                x.For<AgileLizard.Fbopen.Client.Interfaces.IDocumentManager>()
                    .Use<AgileLizard.Fbopen.Client.Managers.DocumentManager>();
            });
        }





        [TestMethod]
        public void CanConfigureGenericRepo()
        {
            bool isValid = false;
            ObjectFactory.Initialize(x =>

            x.Scan(s =>
            {
                s.WithDefaultConventions();
                s.TheCallingAssembly();
                s.LookForRegistries();
            })
            );
            ObjectFactory.Configure(x =>
            {
                x.For<AgileLizard.Fbopen.Client.Interfaces.IDocumentManager>()
                   .Use<AgileLizard.Fbopen.Client.Managers.DocumentManager>();
            });

            try
            {
                ObjectFactory.AssertConfigurationIsValid();
                isValid = true;
            }
            catch (StructureMapConfigurationException ex)
            {
                log.Error(ex);
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
            log.Info(ObjectFactory.WhatDoIHave());

            Assert.AreEqual(true, isValid);
        }



    }
}
