using System;
using System.Collections.Generic;

namespace AgileLizard.Domain
{
    public class Procurement
    {
        public Procurement()
        {
            this.ProcurementAttachments = new List<ProcurementAttachment>();
        }

        public int ProcurementId { get; set; }
        public string data_type { get; set; }
        public string data_source { get; set; }
        public string notice_type { get; set; }
        public string solnbr { get; set; }
        public string solnbr_ci { get; set; }
        public string id { get; set; }
        public string posted_dt { get; set; }
        public string agency { get; set; }
        public string office { get; set; }
        public string location { get; set; }
        public string zipcode { get; set; }
        public string FBO_CLASSCOD { get; set; }
        public string FBO_NAICS { get; set; }
        public string FBO_OFFADD { get; set; }
        public string title { get; set; }
        public string close_dt { get; set; }
        public string FBO_ARCHDATE_dt { get; set; }
        public string FBO_CONTACT { get; set; }
        public string description { get; set; }
        public string listing_url { get; set; }
        public string FBO_EMAIL_ADDRESS { get; set; }
        public string FBO_EMAIL_DESC { get; set; }
        public string FBO_SETASIDE { get; set; }
        public string FBO_POPCOUNTRY { get; set; }
        public string FBO_POPZIP { get; set; }
        public string FBO_POPADDRESS { get; set; }
        public string version { get; set; }
        public string score { get; set; }
        public virtual ICollection<ProcurementAttachment> ProcurementAttachments { get; set; }
    }
}
