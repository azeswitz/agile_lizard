using System;
using System.Configuration;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AgileLizard.Domain;
using AgileLizard.Data;
using AgileLizard.Data.Interfaces;
using AgileLizard.Data.Repositories;
using System.Data.Entity;
using StructureMap;
using StructureMap.Exceptions;
using System.Collections.Generic;
using log4net;
using System.Reflection;

namespace AgileLizard.Tests.Data
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
                x.For<System.Data.Entity.DbContext>().Singleton().Use<AgileLizard.Data.Entities>();
                x.For<IGenericDataRepository<Demo>>().Use<GenericDataRepository<Demo>>();
                x.For<IGenericDataRepository<Procurement>>().Use<GenericDataRepository<Procurement>>();
                x.For<IGenericDataRepository<FactRequestType>>().Use<GenericDataRepository<FactRequestType>>();
                x.For<IGenericDataRepository<FboProfile>>().Use<GenericDataRepository<FboProfile>>();
 
            });
        }



        [TestMethod]
        public void CanWriteToLog()
        {

            log.Debug("Debug message");
            log.Info("Info message");
            log.Warn("Warn message");
            log.Error("Error message");
            log.Fatal("Fatal message");
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
                x.For<System.Data.Entity.DbContext>().Singleton().Use<AgileLizard.Data.Entities>();
                x.For<AgileLizard.Data.Interfaces.IGenericDataRepository<Demo>>().Use<AgileLizard.Data.Repositories.GenericDataRepository<Demo>>();
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



        [TestMethod]
        public void CanAccessDb()
        {
            //ClientRepository _repo = new ClientRepository(_dbcontext);
            IGenericDataRepository<Demo> _clientRepo = ObjectFactory.GetInstance<IGenericDataRepository<Demo>>();
            Assert.AreNotEqual(_clientRepo, null);
        }
    }
}
