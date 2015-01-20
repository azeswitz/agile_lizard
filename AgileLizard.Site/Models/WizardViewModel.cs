using AgileLizard.Business.Dto;
using System;
using System.Collections.Generic;
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
        }
        public IEnumerable<SelectListItem> WhatIDoList {get; set;}
        
        public int WhatIDoId {get; set;}
        /*
        public string CampaignTypeText
        {
            //using enum values where possible, but breaking out 
            //complex values for readability
            get
            {
                switch (WhatIDoId)
                {
                    case (int)CampaignType.PR_MediaRelations:
                        return "PR/Media Relations";
                    case (int)CampaignType.Email:
                        return CampaignType.Email.ToString();
                    case (int)CampaignType.Search:
                        return CampaignType.Search.ToString();
                    case (int)CampaignType.CommunityEvents_HealthFairs:
                        return "Community Events / HealthFairs";
                    case (int)CampaignType.Retargeting:
                        return CampaignType.Retargeting.ToString();
                    case (int)CampaignType.Banner:
                        return CampaignType.Banner.ToString();
                    case (int)CampaignType.SpanishRadio:
                        return "Spanish Radio";
                    case (int)CampaignType.EnglishRadio:
                        return "English Radio";
                    case (int)CampaignType.Organic:
                        return CampaignType.Organic.ToString();
                    case (int)CampaignType.Other:
                        return CampaignType.Other.ToString();
                    case (int)CampaignType.Billboard:
                        return CampaignType.Billboard.ToString();
                    case (int)CampaignType.DirectMail:
                        return "Direct Mail";
                    case (int)CampaignType.HealthKiosk:
                        return "Health Kiosk";
                    case (int)CampaignType.Television:
                        return CampaignType.Television.ToString();
                    case (int)CampaignType.SocialMedia:
                        return "Social Media";
                    default:
                        return CampaignType.Other.ToString();
                }
            }*/
         public Dictionary<int, string> WhatIDoType = new Dictionary<int, string>
        {
            {1, "Research open opportunities for my company"},
            {2, "Response to new business opportunities"},
            {3, "Network with other professionals for teaming opportunites"}
        };

        public string WhatIDo { get; set; }
        public string Params { get; set; }

        public IList<FactRequestTypeDto> FactRequestTypeList { get; set; }
        public IList<FactSetAsideDto> FactSetAsideList { get; set; }
        public List<string> FactRequestTypeSelections { get; set; }
        public List<string> FactSetAsideSelections { get; set; }
    }

   

}