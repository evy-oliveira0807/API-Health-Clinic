using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Health_Clinic.Domains
{
    [Table(nameof(Clinica))]
    public class Clinica
    {
        public Guid IdClinica { get; set; } = Guid.NewGuid();

  [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "o nome fantasia é obrigatória")]
        public string? NomeFantasia { get; set; }


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O endereço é obrigatório")]
        public string? Endereco { get; set; }

        [Column(TypeName = "VARCHAR(14)")]
        [Required(ErrorMessage = "o CNPJ é obrigatório")]
        public string? CNPJ { get; set; }

        [Column(TypeName = "TIME")]
        [Required(ErrorMessage = "O horário de abertura é obrigatório")]
        public TimeOnly horarioAbertura { get; set; }

        [Column(TypeName = "TIME")]
        [Required(ErrorMessage = "O horário de fechamento é obrigatório")]
        public TimeOnly horarioFechamento { get; set; }     

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "a razao social é obrigatória")]
        public string? RazaoSocial { get; set; }
    }
}

