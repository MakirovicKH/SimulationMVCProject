using AutoMapper;
using Listrace.BL.DTOs.PlacesDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listrace.BL.Profiles
{
    public class PlacesProfile : Profile 
    {
        public PlacesProfile()
        {
            CreateMap<Profile,AddPlacesDTO>().ReverseMap();
            CreateMap<Profile,GetPlacesDTO>().ReverseMap();
            CreateMap<Profile,UpdatePlacesDTO>().ReverseMap();
            CreateMap<GetPlacesDTO, UpdatePlacesDTO>().ReverseMap();
        }
    }
}
