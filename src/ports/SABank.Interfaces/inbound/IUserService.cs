using SABank.Domain.Dtos;

namespace SABank.Interfaces.Inbound
{
    public interface IUserService
    {
        UserDto GetByLogin(int idLogin);
    }
}
