using SABank.Domain.dtos;

namespace SABank.Interfaces.inbound
{
    public interface IUserService
    {
        UserDto GetByLogin(int idLogin);
    }
}
