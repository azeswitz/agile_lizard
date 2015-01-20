using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileLizard.Business.Dto
{
    public class FactSetAsideDto
    {
        public int FactId { get; set; }
        public string FactName { get; set; }
        public string FboName { get; set; }
        public int SortOrder { get; set; }

        public bool IsSelected { get; set; }
    }
}
