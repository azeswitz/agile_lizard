using System;
using System.Linq;
using System.Reflection;
using AgileLizard.Data.Interfaces;
using AgileLizard.Domain;
using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StructureMap;

namespace AgileLizard.Tests.Data
{
    [TestClass]
    public class ProcurementTests
    {
        [TestInitialize]
        public void Init()
        {
            IoC.Init();
        }


    }
}
