using Microsoft.EntityFrameworkCore;
using SABank.Domain.entities;

namespace SABank.Infra.Context
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options) : base(options){}

        public DbSet<UserEntity> tb_sab_0002 { get; set; }
    }
}
