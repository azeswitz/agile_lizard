using System;
using System.Collections.Generic;


namespace AgileLizard.Domain
{
    public class ProcurementAttachment
    {
        public int ProcurementAttachmentId { get; set; }
        public Nullable<int> ProcurmentId { get; set; }
        public string SystemPath { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public virtual Procurement Procurement { get; set; }
    }
}
