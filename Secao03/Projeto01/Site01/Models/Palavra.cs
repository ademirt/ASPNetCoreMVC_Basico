using Site01.Library.Validation;
using System.ComponentModel.DataAnnotations;

namespace Site01.Models
{
    public class Palavra
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo 'Nome' é obrigatório!")]
        [MaxLength(70, ErrorMessage = "'Nome' dever contar até 70 caracteres!")]
        [UnicoNomePalavra]
        public string Nome { get; set; }

        //1-facil,2-medio,3-difícil
        public byte? Nivel { get; set; }
    }
}
