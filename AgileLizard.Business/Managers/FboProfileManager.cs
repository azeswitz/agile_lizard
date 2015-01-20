using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgileLizard.Business.Interfaces;
using AgileLizard.Business.Dto;
using AgileLizard.Domain;
using AgileLizard.Data.Interfaces;
using AutoMapper;
using AutoMapper.Mappers;
using log4net;
using System.Reflection;
using System.Linq.Expressions;


namespace AgileLizard.Business.Managers
{
    public class FboProfileManager : IFboProfileManager
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        IGenericDataRepository<FboProfile> _repo;
        public FboProfileManager(IGenericDataRepository<FboProfile> repo)
        {
            _repo = repo;
        }
        public IList<FboProfileDto> GetList(params Expression<Func<FboProfile, object>>[] navigationProperties)
        {
            IList<FboProfile> _list;
            _list = _repo.GetAll(navigationProperties).ToList<FboProfile>();
            return Mapper.Map<IList<FboProfile>, IList<FboProfileDto>>(_list);
        }

        public FboProfileDto SaveOrUpdate(FboProfileDto x)
        {
            FboProfile p = Mapper.Map<FboProfile>(x);

            //Now save the record to the local repository
            try
            {
                if (p.FboProfileId != null)
                {
                    _repo.Update(p);
                }
                else
                {
                    p.FboProfileId = Guid.NewGuid();
                    _repo.Add(p);
                }

            }
            catch (Exception e)
            {
                log.Error(e);
            }
            return Mapper.Map<FboProfileDto>(p);
        }

        public FboProfileDto GetById(Guid id)
        {
            FboProfile p = _repo.GetSingle(x => x.FboProfileId == id);
            return Mapper.Map<FboProfileDto>(p);
        }

        public bool Delete(FboProfileDto x)
        {
            throw new NotImplementedException();
        }
    }
}
