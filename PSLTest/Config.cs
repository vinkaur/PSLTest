using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSLTest
{
    public class Config
    {
        public static void Configure()
        {
            Mapper.CreateMap<request, Item>()
                .ForMember(s => s.ItemId, opt => opt.MapFrom(c => c.RsuiteId));                       
            Mapper.CreateMap<Structure, Data>()
               .ForMember(s => s.Sequence, opt => opt.MapFrom(c => c.Sequence));
            Mapper.CreateMap<Structure, BfwTocContents>()
                .ForMember(s => s.Sequence, opt => opt.MapFrom(c => c.Sequence));
            Mapper.CreateMap<ContentMetaData, Data>()
                .ForMember(s => s.Title, opt => opt.MapFrom(c => c.Title));
        }
    }
}