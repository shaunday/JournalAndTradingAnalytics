﻿using AutoMapper;
using AutoMapper.EquivalencyExpression;
using DayJT.Journal.DataEntities.Entities;
using DayJTrading.Web.Services.Models.Journal;

namespace DayJT.Web.API.Mapping
{
    public class JournalObjectsMappingProfile : Profile
    {
        public JournalObjectsMappingProfile()
        {
            CreateMap<DataElement, DataElementModel>().EqualityComparison((dto, m) => dto.Id == m.Id);
            CreateMap<TradeElement, TradeElementModel>().EqualityComparison((dto, m) => dto.Id == m.Id);
            CreateMap<TradeComposite, TradeCompositeModel>().EqualityComparison((dto, m) => dto.Id == m.Id);
        }
    }
}
