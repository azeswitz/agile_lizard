using System;
using System.Linq;
using System.Reflection;
using AgileLizard.Business.Dto;
using AgileLizard.Business.Interfaces;
using AgileLizard.Domain;
using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StructureMap;
using AutoMapper;
using AutoMapper.Mappers;

namespace AgileLizard.Tests.Business
{
    [TestClass]
    public class FboProfileTests
    {
        [TestInitialize]
        public void Init()
        {
            IoC.Init();
            AutoMapperConfig.Init();
        }

        private static string goodGuid = "803CF004-EFD8-4F5F-B46C-8756C191D4BB";
        public void FboProfile_CanGetList()
        {
            throw new NotImplementedException();
        }
        [TestMethod]
        public void Biz_FboProfile_CanSave()
        {
            IFboProfileManager _mgr = ObjectFactory.GetInstance<IFboProfileManager>();
            FboProfileDto f = new FboProfileDto
            {
                FboProfileId=Guid.NewGuid(),
                FirstName = "Justin",
                LastName = "Thyme",
                MiddleName = "Nick",
                PersonBlurb="This is the personal blurb",
                //NEED a business name
                BusinessBlurb="This is the business blurb",
                BusinessType="This is the business type",
                 CapabilityBlurb="This is the capability blurb",
                CreatedDate = DateTime.Now,
                UpdateDate = DateTime.Now,
            };
            FboProfileDto x = _mgr.SaveOrUpdate(f);

            Assert.AreNotEqual(null, f.FboProfileId);
        }
        [TestMethod]
        public void Biz_FboProfile_CanUpdate()
        {
            IFboProfileManager _mgr = ObjectFactory.GetInstance<IFboProfileManager>();

            FboProfileDto f = new FboProfileDto
            {
                FboProfileId=Guid.Parse(goodGuid),
                FirstName = "Justin",
                LastName = "Thyme",
                MiddleName = "Nick",
                PersonBlurb="This is the personal blurb updated",
                //NEED a business name
                BusinessBlurb="This is the business blurb",
                BusinessType="This is the business type",
                 CapabilityBlurb="This is the capability blurb",
                CreatedDate = DateTime.Now,
                UpdateDate = DateTime.Now,
            };
            FboProfileDto x = _mgr.SaveOrUpdate(f);

            Assert.AreNotEqual(null, f.FboProfileId);
        }

         [TestMethod]
        public void Biz_FboProfile_CanGetById()
        {
            IFboProfileManager _mgr = ObjectFactory.GetInstance<IFboProfileManager>();
            FboProfileDto f = _mgr.GetById(Guid.Parse(goodGuid));
            Assert.AreNotEqual(null, f);
        }

        public void FboProfile_CanDelete()
        {
            throw new NotImplementedException();
        }

    }
}
