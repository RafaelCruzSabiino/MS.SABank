using System.ComponentModel.DataAnnotations.Schema;

namespace SABank.Domain.Entities
{
    public class UserEntity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("id_login")]
        public int IdLogin { get; set; }

        [Column("nome")]
        public string Nome { get; set; } = string.Empty;

        [Column("cpf")]
        public string Cpf { get; set; } = string.Empty;

        [Column("dt_nascimento")]
        public DateTime DtNascimento { get; set; }

        [Column("nome_mae")]
        public string NomeMae { get; set; } = string.Empty;
    }
}
