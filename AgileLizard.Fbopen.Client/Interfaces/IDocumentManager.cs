using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgileLizard.Fbopen.Client.Dto;

namespace AgileLizard.Fbopen.Client.Interfaces
{
    public interface IDocumentManager
    {
        IList<Doc> GetRecords(string searchParams, int pageNum=0);
       
    }
}
