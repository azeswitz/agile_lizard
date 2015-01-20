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
    public class ProcurementManager : IProcurementManager
    {
        
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        IGenericDataRepository<Procurement> _repo;

        //Initialize manager, inject repository instance and configure automapper
        public ProcurementManager(IGenericDataRepository<Procurement> repo)
        {
            this._repo = repo;
        }

        //Return a list of objects.  Intentional return of IList vs. IQueryable to 
        //more cleanly keep application layers clean.  
        //Developer may apply Linq Expressions as parameters to "GetAll" method to return child objects
        //or filter results to a subset of the list
        public IList<ProcurementDto> GetList()
        {
            IList<Procurement> _list;
            _list = _repo.GetAll().ToList<Procurement>();
            return Mapper.Map<IList<Procurement>, IList<ProcurementDto>>(_list);
        }

        //Could be split into two methods.  Based on the database paradigm, an ID will
        //only exist after the object has been atomically saved once and persisted
        public ProcurementDto SaveOrUpdate(ProcurementDto x)
        {
            Procurement p = Mapper.Map<Procurement>(x);
            try
            {
                if (p.ProcurementId > 0)
                {
                    _repo.Update(p);
                }
                else
                {
                    _repo.Add(p);
                }

            }
            catch (Exception e)
            {
                log.Error(e);
            }
            return Mapper.Map<ProcurementDto>(p);
        }

        public ProcurementDto GetById(int id)
        {
            Procurement p = _repo.GetSingle(x => x.ProcurementId == id);
            return Mapper.Map<ProcurementDto>(p);
        }

        //Intentionally not implemented
        public bool DeleteProcurement(ProcurementDto x)
        {
            throw new NotImplementedException();
        }
    }
}
