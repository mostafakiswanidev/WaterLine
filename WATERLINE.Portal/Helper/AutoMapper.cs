using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WATERLINE.Entities;
using WATERLINE.Portal.ViewModels.User;
using WATERLINE.Services.DTOs.Users;

namespace WATERLINE.Portal.Helper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<UserViewModel, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}
