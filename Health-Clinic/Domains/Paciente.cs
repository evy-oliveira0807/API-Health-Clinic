using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Health_Clinic.Domains
{
    [Table(nameof(Paciente))]
    public class Paciente
    {
        [Key]
        public Guid IdPaciente { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(150)")]
        [Required(ErrorMessage = "O nome do usuário é obrigatório")]
        public string? Nome { get; set; }


        [Column(TypeName = "VARCHAR(20)")]
        [Required(ErrorMessage = "O RG do usuário é obrigatório")]
        public string? RG { get; set; }

        [Column(TypeName = "VARCHAR(20)")]
        [Required(ErrorMessage = "O CPF do usuário é obrigatório")]
        public string? CPF { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "A data de nascimento é obrigatória")]
        public DateTime DataNascimento { get; set; }

        [Column(TypeName = "VARCHAR(20)")]
        [Required(ErrorMessage = "O Telefone do usuário é obrigatório")]
        public string? Telefone { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O endereço do paciente é obrigatório")]
        public string? Endereco { get; set; }

        //ref.tabela Usuario
        [Required(ErrorMessage = "O ID do usuário é obrigatório")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }

      
      
    }
}
