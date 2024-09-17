using SABank.Domain.entities;

namespace SABank.Interfaces.outbound
{
    public interface IUserRepository
    {
        UserEntity? GetByLogin(int idLogin);
    }
}
