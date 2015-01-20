using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AgileLizard.Business.Dto;

namespace AgileLizard.Business.Interfaces
{
    public interface IProcurementManager
    {

        IList<ProcurementDto> GetList();
        ProcurementDto SaveOrUpdate(ProcurementDto x);
        ProcurementDto GetById(int id);
        bool DeleteProcurement(ProcurementDto x);
    }
}
