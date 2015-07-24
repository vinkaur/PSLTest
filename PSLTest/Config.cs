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
            Mapper.CreateMap<request, Data>()
                 .ForMember(s => s.Type, opt => opt.MapFrom(c => c.Type.Contains("learningcurve") ? "CustomActivity" : c.Type.Contains("resource") ? "Resource" : c.Type.Contains("arga") ? "CustomActivity" : c.Type.Contains("dropbox") ? "Assignment" : c.Type.Contains("unit") ? "Folder" : c.Type.Contains("quiz") ? "Assessment" : c.Type));
       
            Mapper.CreateMap<Structure, Data>()
               .ForMember(s => s.Sequence, opt => opt.MapFrom(c => c.Sequence));
            Mapper.CreateMap<Structure, BfwTocContents>()
                .ForMember(s => s.ParentId, opt => opt.MapFrom(c => c.ParentId))
                .ForMember(s => s.Sequence, opt => opt.MapFrom(c => c.Sequence));
            Mapper.CreateMap<ContentMetaData, Data>()
                .ForMember(s => s.Title, opt => opt.MapFrom(c => c.Title));
        }
    }
}