using AutoMapper;
using SABank.Domain.Dtos;
using SABank.Domain.Entities;

namespace SABank.Domain.Mappers
{
    public class UserMapper : Profile
    {
        public UserMapper()
            => CreateMap<UserEntity, UserDto>().ReverseMap();
    }
}
