using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileLizard.Domain
{
    public partial class Highlight
    {
        public int HighlightsId { get; set; }
        public int ProcurementId { get; set; }
        public string description { get; set; }
    }
}
