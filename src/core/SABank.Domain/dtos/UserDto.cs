namespace SABank.Domain.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public DateTime DtNascimento { get; set; }
        public string NomeMae { get; set; } = string.Empty;
    }
}
