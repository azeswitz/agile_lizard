using AgileLizard.Business.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgileLizard.Site.Models
{
    public class WizardViewModel
    {
        public WizardViewModel()
        {
            WhatIDoList = WhatIDoType.Select(v => new SelectListItem
            {
                Text = v.Value,
                Value = v.Key.ToString()
            });

            FilterTypeList = FilterType.Select(v => new SelectListItem
            {
                Text = v.Value,
                Value = v.Key.ToString()
            });
        }
        public IEnumerable<SelectListItem> WhatIDoList {get; set;}
        
        
        public int WhatIDoId {get; set;}
        
         public Dictionary<int, string> WhatIDoType = new Dictionary<int, string>
        {
            {1, "Research open opportunities for my company"},
            {2, "Response to new business opportunities"},
            {3, "Network with other professionals for teaming opportunites"}
        };

         public IEnumerable<SelectListItem> FilterTypeList { get; set; }
         public Dictionary<string, string> FilterType = new Dictionary<string, string>
        {
            {"FactRequestType", "Request Type"},
            {"FactSetAside", "Set Aside Type"},
            {"-", "..."}
        };
        
         public IEnumerable<SelectListItem> OperatorList { get; set; }
         public Dictionary<string, string> OperatorType = new Dictionary<string, string>
        {
            {"=", "Equals"},
            {"<>", "Does Not Equal"},
            {"-", "..."}
        };

        [Display(Name="What I Do...")]
        public string WhatIDo { get; set; }

        [Display(Name = "Keywords")]
        [Required(ErrorMessage="Prototype only: at least one keyword is required")]
        public string Params { get; set; }

        public IList<FactRequestTypeDto> FactRequestTypeList { get; set; }
        public IList<FactSetAsideDto> FactSetAsideList { get; set; }
        public List<string> FactRequestTypeSelections { get; set; }
        public List<string> FactSetAsideSelections { get; set; }
    }

   

}