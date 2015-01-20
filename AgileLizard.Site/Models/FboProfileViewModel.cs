using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgileLizard.Site.Models
{
    public class FboProfileViewModel
    {
        public System.Guid FboProfileId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public byte[] PersonImage { get; set; }
        public string PersonBlurb { get; set; }
        public string BusinessType { get; set; }
        public byte[] BusinessLogo { get; set; }
        public string BusinessBlurb { get; set; }
        public string CapabilityBlurb { get; set; }
        public string OtherInterestBlurb { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }


    }
}