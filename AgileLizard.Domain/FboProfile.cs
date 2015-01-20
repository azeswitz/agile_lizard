using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileLizard.Domain
{
    public class FboProfile
    {
        /*
         * 	[FboProfileId] [int] Identity(1,1),
	[FirstName] [varchar](500) NOT NULL,
	[MiddleName] [varchar](500) NULL,
	[LastName] [varchar](500) NULL,
	[PersonImage] [binary] null,
	[PersonBlurb] [text] null,
	[BusinessType] [varchar](500) NULL,
	[BusinessLogo] [binary] null,
	[BusinessBlurb] [text] null,
	[CapabilityBlurb] [text] null,
	[OtherInterestBlurb] [text] null,*/

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
