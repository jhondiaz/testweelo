using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeelo.DTOs;
using TestWeelo.Entities.POCOs;

namespace TestWeelo.UseCases.Mappings
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<CreatePropertyDTO, Property>().ReverseMap();
            CreateMap<Property, PropertyDTO>().ReverseMap();
            CreateMap<UpdatePropertyDTO, Property>().ReverseMap();
            CreateMap<CreateOwnerDTO, Owner>().ReverseMap();
            CreateMap<Owner, OwnerDTO>().ReverseMap();
            CreateMap<CreatePropertyImageDTO, PropertyImage>().ReverseMap();
            CreateMap<PropertyImage, PropertyImageDTO>().ReverseMap();
        }
    }
}
