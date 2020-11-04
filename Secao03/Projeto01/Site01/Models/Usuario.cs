using System.ComponentModel.DataAnnotations;

namespace Site01.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "Campo 'Email' é obrigatório!")]
        [EmailAddress(ErrorMessage = "O campo 'Email' é inválido!!!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo 'Senha' é obrigatório!")]
        public string Senha { get; set; }
    }
}
