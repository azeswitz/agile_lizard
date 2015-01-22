using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using AgileLizard.Business.Dto;


namespace AgileLizard.Site.Models
{
    public class SearchViewModel
    {
        public SearchViewModel()
        {
            this.Params = String.Empty;
            this.StartingRecord = 0;
            this.StartDate = DateTime.Now.AddYears(-1).ToShortDateString();
            this.EndDate = DateTime.Now.ToShortDateString();
            this.FboDocs = new List<FbOpenDocumentViewModel>();
        }
        //define mocked search parameters
        [Display(Name = "Keywords")]
        [Required(ErrorMessage = "Prototype only: at least one keyword is required")]
        public string Params { get; set; }
        public int StartingRecord { get; set; }

        public IList<FbOpenDocumentViewModel> FboDocs { get; set; }

        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public IList<FactRequestTypeDto> FactRequestTypeList { get; set; }
        public IList<FactSetAsideDto> FactSetAsideList { get; set; }

    }

}