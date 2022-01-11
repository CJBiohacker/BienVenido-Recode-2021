using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Formulario
    {
        [Key]
        [Required]
        public int IdFormulario { get; set; }

        [MaxLength(100)]
        [Required]
        public string NomeCompleto { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }

        [MaxLength(15)]
        [Required]
        public string Telefone { get; set; }

        [MaxLength(5000)]
        [Required]
        public string Mensagem { get; set; }
    }
}
