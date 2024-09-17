using AutoMapper;
using SABank.Domain.dtos;
using SABank.Domain.entities;

namespace SABank.Domain.mappers
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<UserEntity, UserDto>()
                .ReverseMap();
        }
    }
}
