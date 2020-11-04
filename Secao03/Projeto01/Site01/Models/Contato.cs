using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Site01.Models
{
    public class Contato
    {
        [Required(ErrorMessage = "Campo 'Nome' é obrigatório!")]
        [MaxLength(50,ErrorMessage ="'Nome' dever contar até 50 caracteres!")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Campo 'Email' é obrigatório!")]
        [MaxLength(70, ErrorMessage = "'Email' dever contar até 70 caracteres!")]
        [EmailAddress]
        public string Email { get; set; }


        [Required(ErrorMessage = "Campo 'Assunto' é obrigatório!")]
        [MaxLength(80, ErrorMessage = "'Assunto' dever contar até 80 caracteres!")]
        public string Assunto { get; set; }


        [Required(ErrorMessage = "Campo 'Mensagem' é obrigatório!")]
        [MaxLength(2000, ErrorMessage = "'Mensagem' dever contar até 2000 caracteres!")]
        public string Mensagem { get; set; }

    }
}
