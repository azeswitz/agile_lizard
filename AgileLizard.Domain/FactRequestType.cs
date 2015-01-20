using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileLizard.Domain
{
	public class FactRequestType
	{

		/*
		 * 	[FactName] [varchar](500) NOT NULL,
	[FboName] [varchar](500) NULL,
	[SortOrder] [int],*/

        public int FactId { get; set; }
		public string FactName { get; set; }
		public string FboName { get; set; }
		public int SortOrder { get; set; }
	}
}
