﻿using SABank.Domain.entities;
using SABank.Infra.Context;
using SABank.Interfaces.outbound;

namespace SABank.Infra.repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _userContext;

        public UserRepository(UserContext userContext)
        {
            _userContext = userContext;
        }

        public UserEntity? GetByLogin(int idLogin)
            => _userContext.tb_sab_0002.FirstOrDefault(e => e.IdLogin == idLogin);
    }
}