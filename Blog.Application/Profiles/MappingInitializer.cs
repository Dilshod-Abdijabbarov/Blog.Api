using AutoMapper;
using Blog.Application.DTOs;
using Blog.Application.DTOs.User;
using Blog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Profiles
{
   public  class MappingInitializer : Profile
    {

        public MappingInitializer()
        {
            CreateMap<UserDto, User>().ReverseMap();

            CreateMap<UserCreateDto, User>().ReverseMap();

            CreateMap<BlogDto, Blogs>().ReverseMap();

            CreateMap<BlogForCreateDto, Blogs>().ReverseMap();
        }

    }
}
