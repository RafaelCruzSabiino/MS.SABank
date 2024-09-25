using AutoMapper;
using SABank.Domain.Dtos;
using SABank.Interfaces.Inbound;
using SABank.Interfaces.Outbound;

namespace SABank.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public UserDto GetByLogin(int idLogin)
        {
            UserDto user = new();

            try
            {
                user = _mapper.Map<UserDto>(_userRepository.GetByLogin(idLogin));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex); // VER LOG
            }

            return user;
        }
    }
}
