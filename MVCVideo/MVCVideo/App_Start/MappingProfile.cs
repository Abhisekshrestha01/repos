using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCVideo.Dtos;
using MVCVideo.Models;

namespace MVCVideo.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}