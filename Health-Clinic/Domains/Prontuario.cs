using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Health_Clinic.Domains
{
    [Table(nameof(Prontuario))]
    public class Prontuario
    {

        [Key]
        public Guid IdProntuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "TEXT")]
        public string? Descricao { get; set; }
        [Required(ErrorMessage = "O ID do Paciente é obrigatório")]
        public Guid IdPaciente { get; set; }

        [ForeignKey(nameof(IdPaciente))]
        public Paciente? Paciente { get; set; }
    }
}
