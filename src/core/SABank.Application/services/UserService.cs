using AutoMapper;
using Microsoft.Extensions.Logging;
using SABank.Domain.Dtos;
using SABank.Interfaces.Inbound;
using SABank.Interfaces.Outbound;

namespace SABank.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<UserService> _logger;

        public UserService(IUserRepository userRepository, IMapper mapper, ILogger<UserService> logger)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public UserDto GetByLogin(int idLogin)
        {
            UserDto user = new();

            try
            {
                user = _mapper.Map<UserDto>(_userRepository.GetByLogin(idLogin));
                _logger.LogDebug("teste");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex); // VER LOG
            }

            return user;
        }
    }
}
