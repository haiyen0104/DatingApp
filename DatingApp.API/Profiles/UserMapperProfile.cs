using AutoMapper;
using DatingApp.API.Data.Entities;
using DatingApp.API.DTOs;
using DatingApp.API.Extensions;

namespace DatingApp.API.Profiles
{
    public class UserMapperProfiles : Profile
    {
        public UserMapperProfiles(){
            CreateMap<User, MemberDto>()
            .ForMember(
                dest => dest.Age,
                option => option.MapFrom(src =>src.DateOfBirth.GetAge())
            );
            CreateMap<RegisterUserDto, User>();
        }
    }
}