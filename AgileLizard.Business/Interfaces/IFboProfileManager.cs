using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AgileLizard.Business.Dto;
using AgileLizard.Domain;
using System.Linq.Expressions;

namespace AgileLizard.Business.Interfaces
{
    public interface IFboProfileManager
    {

        IList<FboProfileDto> GetList(params Expression<Func<FboProfile, object>>[] navigationProperties);
        FboProfileDto SaveOrUpdate(FboProfileDto x);
        FboProfileDto GetById(Guid id);
        bool Delete(FboProfileDto x);
    }
}
