using AgileLizard.Business.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgileLizard.Site.Models
{
    public class WizardViewModel
    {

        public List<string> WhatIDoList = new List<string>
        {
            "Research open opportunities for my company",
            "Response to new business opportunities",
            "Network with other professionals for teaming opportunites"
        };
        public string WhatIDo { get; set; }
        public string Params { get; set; }

        public IList<FactRequestTypeDto> FactRequestTypeList { get; set; }
        public IList<FactSetAsideDto> FactSetAsideList { get; set; }
        public List<string> FactRequestTypeSelections { get; set; }
        public List<string> FactSetAsideSelections { get; set; }
    }
}