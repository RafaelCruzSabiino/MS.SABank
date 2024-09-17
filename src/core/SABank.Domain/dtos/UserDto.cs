using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABank.Domain.dtos
{
    public class UserDto
    {
        public int id { get; set; }
        public string nome { get; set; } = string.Empty;
        public string cpf { get; set; } = string.Empty;
        public DateTime dt_nascimento { get; set; }
        public string nome_mae { get; set; } = string.Empty;
    }
}
