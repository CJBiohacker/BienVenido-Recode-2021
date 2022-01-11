using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Curriculo
    {
        [Key]
        [Required]
        public int idCurriculo { get; set; }

        [MaxLength(50)]
        [Required]
        public string Nome { get; set; }

        [MaxLength(50)]
        [Required]
        public string Endereco { get; set; }

        [MaxLength(15)]
        public string Telefone { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }

        [MaxLength(45)]
        [Required]
        public string Nacionalidade { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Required]
        public string DataNasc { get; set; }

        [MaxLength(50)]
        [Required]
        public string Empresa1 { get; set; }

        [MaxLength(45)]
        [Required]
        public string CargoTrab1 { get; set; }

        [MaxLength(20)]
        [Required]
        public string PeriodoTrab1 { get; set; }

        [MaxLength(250)]
        [Required]
        public string DescricaoTrab1 { get; set; }

        [MaxLength(50)]
        [Required]
        public string Empresa2 { get; set; }

        [MaxLength(45)]
        [Required]
        public string CargoTrab2 { get; set; }

        [MaxLength(20)]
        [Required]
        public string PeriodoTrab2 { get; set; }

        [MaxLength(250)]
        [Required]
        public string DescricaoTrab2 { get; set; }

        [MaxLength(45)]
        [Required]
        public string Instituicao1 { get; set; }

        [MaxLength(45)]
        [Required]
        public string Nivel1 { get; set; }

        [MaxLength(45)]
        [Required]
        public string Curso1 { get; set; }

        [MaxLength(45)]
        [Required]
        public string Instituicao2 { get; set; }

        [MaxLength(45)]
        [Required]
        public string Nivel2 { get; set; }

        [MaxLength(45)]
        [Required]
        public string Curso2 { get; set; }

        [MaxLength(45)]
        [Required]
        public string Habilidades { get; set; }

        [MaxLength(45)]
        [Required]
        public string Idioma2 { get; set; }

        [MaxLength(45)]
        [Required]
        public string Idioma3 { get; set; }
    }
}
