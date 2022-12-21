using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using UserApi.Data.Requests;
using UserApi.Data.Response;
using UserApi.Data.Dtos;
using UserApi.Models;

namespace UserApi.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, User>();
            CreateMap<User, UserDto>();
            CreateMap<CreateUserRequest, UserDto>();
            CreateMap<UserDto, CreateUserResponse>();
        }
    }
}