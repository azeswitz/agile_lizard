using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AgileLizard.Business.Dto;
using AgileLizard.Business.Interfaces;
using AgileLizard.Business;
using StructureMap;
using log4net;
using System.Reflection;

namespace AgileLizard.Tests.Business
{
    [TestClass]
    public class ProcurementTests
    {
        [TestInitialize]
        public void Init()
        {
            IoC.Init();
        }

        [TestMethod]
        public void CanGetList()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void CanSaveOrUpdate()
        {
            //IPersonManager _mgr = ObjectFactory.GetInstance<IPersonManager>();
            throw new NotImplementedException();
        }

        [TestMethod]
        public void CanGetById(int id)
        {
            throw new NotImplementedException();
        }
        [TestMethod]
        public void CanDelete()
        {
            throw new NotImplementedException();
        }
    }
}
