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


namespace AgileLizard.Business.Managers
{
    public class FactManager : IFactManager
    {
        IGenericDataRepository<FactRequestType> _typeRepo;
        IGenericDataRepository<FactSetAside> _setasideRepo;

        public FactManager(
            IGenericDataRepository<FactRequestType> typeRepo,
            IGenericDataRepository<FactSetAside> setasideRepo)
        {
            _typeRepo = typeRepo;
            _setasideRepo = setasideRepo;
        }
        public IList<FactRequestTypeDto> GetFactTypeList()
        {
            IList<FactRequestType> myList = _typeRepo.GetAll();
            return Mapper.Map<IList<FactRequestType>,IList<FactRequestTypeDto>>(myList);
        }

        public IList<FactSetAsideDto> GetSetAsideList()
        {
            IList<FactSetAside> myList = _setasideRepo.GetAll();
            return Mapper.Map<IList<FactSetAside>, IList<FactSetAsideDto>>(myList);
        }
    }
}
