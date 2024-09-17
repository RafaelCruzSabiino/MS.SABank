namespace SABank.Domain.entities
{
    public class UserEntity
    {
        public int id { get; set; }
        public int id_login { get; set; }
        public string nome { get; set; } = string.Empty;
        public string cpf { get; set; } = string.Empty;
        public DateTime dt_nascimento { get; set; }
        public string nome_mae { get; set; } = string.Empty;
    }
}
