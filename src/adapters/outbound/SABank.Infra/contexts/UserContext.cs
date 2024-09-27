using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SABank.Domain.Entities;

namespace SABank.Infra.Context
{
    public class UserContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public UserContext(IConfiguration configuration) 
            => Configuration = configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder options) 
            => options.UseNpgsql(Configuration.GetConnectionString("pgsql"));

        public DbSet<UserEntity> tb_sab_0002 { get; set; }
    }
}
