using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AgileLizard.Business.Dto;

namespace AgileLizard.Business.Interfaces
{
    public interface IFactManager
    {
        IList<FactRequestTypeDto> GetFactTypeList();
        IList<FactSetAsideDto> GetSetAsideList();
    }
}
