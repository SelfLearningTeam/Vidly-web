﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Models;
using Vidly.Dtos;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<Genre, GenreDto>();

            Mapper.CreateMap<CustomerDto, Customer>();           
            Mapper.CreateMap<MovieDto, Movie>();

        }
    }
}