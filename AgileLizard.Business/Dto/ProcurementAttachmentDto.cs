using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileLizard.Business.Dto
{
    public class ProcurementAttachmentDto
    {
        public int ProcurementAttachmentId { get; set; }
        public Nullable<int> ProcurmentId { get; set; }
        public string SystemPath { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public virtual ProcurementDto Procurement { get; set; }
    }
}
