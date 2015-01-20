using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Mappers;
using AgileLizard.Business.Dto;
using AgileLizard.Business.Interfaces;
using AgileLizard.Domain;
using AgileLizard.Data.Interfaces;
using AgileLizard.Fbopen.Client.Dto;
using AgileLizard.Site.Models;
using System.Reflection;


namespace AgileLizard.Tests.Business
{
    public static class AutoMapperConfig
    {
        public static void Init()
        {
            try
            {
                var useless = new ListSourceMapper();
                Mapper.Initialize(cfg =>
                    {
                        //Automapper config for Client section
                        cfg.CreateMap<Procurement, ProcurementDto>()
                            .ReverseMap();
                        cfg.CreateMap<Doc, FbOpenDocumentViewModel>();
                        cfg.CreateMap<Highlights, HighlightsViewModel>();
                        cfg.CreateMap<FbOpenDocumentViewModel, ProcurementDto>()
                                .ReverseMap();
                        cfg.CreateMap<HighlightsViewModel, HighlightsDto>()
                            .ReverseMap();
                        cfg.CreateMap<FboProfile, FboProfileDto>()
                            .ReverseMap();
                        cfg.CreateMap<FactRequestType, FactRequestTypeDto>();
                        cfg.CreateMap<FactSetAside, FactSetAsideDto>();
                    });
            }
            catch (AutoMapperConfigurationException ace)
            {
                throw ace;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
