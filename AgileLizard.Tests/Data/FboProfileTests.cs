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
    public class FboProfileTests
    {
        [TestInitialize]
        public void Init()
        {
            IoC.Init();
        }

        private static string goodGuid = "803CF004-EFD8-4F5F-B46C-8756C191D4BB";
        public void FboProfile_CanGetList()
        {
            throw new NotImplementedException();
        }
        [TestMethod]
        public void FboProfile_CanSave()
        {
            IGenericDataRepository<FboProfile> _repo = ObjectFactory.GetInstance<IGenericDataRepository<FboProfile>>();
            FboProfile f = new FboProfile
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
            _repo.Add(f);

            Assert.AreNotEqual(null, f.FboProfileId);
        }
        [TestMethod]
        public void FboProfile_CanUpdate()
        {
            IGenericDataRepository<FboProfile> _repo = ObjectFactory.GetInstance<IGenericDataRepository<FboProfile>>();

           FboProfile f = new FboProfile
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
            _repo.Update(f);

            Assert.AreNotEqual(null, f.FboProfileId);
        }

         [TestMethod]
        public void FboProfile_CanGetById()
        {
            IGenericDataRepository<FboProfile> _repo = ObjectFactory.GetInstance<IGenericDataRepository<FboProfile>>();
            FboProfile f = _repo.GetSingle(x => x.FboProfileId == Guid.Parse(goodGuid));
            Assert.AreNotEqual(null, f);
        }

        public void FboProfile_CanDelete()
        {
            throw new NotImplementedException();
        }

    }
}
