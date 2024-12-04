using SABank.Domain.Entities;

namespace SABank.Interfaces.Outbound
{
    public interface IUserRepository
    {
        UserEntity? GetByLogin(int idLogin);
    }
}
