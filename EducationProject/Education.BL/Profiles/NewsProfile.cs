using AutoMapper;
using Education.BL.DTOs.NewsDTO;
using Education.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.BL.Profiles
{
    public class NewsProfile : Profile
    {
        public NewsProfile()
        {
            CreateMap<News, AddNewsDTO>().ReverseMap();
            CreateMap<News, UpdateNewsDTO>().ReverseMap();
            CreateMap<News, GetNewsDTO>().ReverseMap();
            CreateMap<GetNewsDTO, UpdateNewsDTO>().ReverseMap();
        }

    }
}
