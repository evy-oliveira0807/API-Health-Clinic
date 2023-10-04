using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Health_Clinic.Domains
{
    [Table(nameof(Comentario))]
    public class Comentario
    {
        [Key]
        public Guid IdComentario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(256)")]
        [Required(ErrorMessage = "O comentário sobre a clinica é obrigatório!")]
        public string? Descricao { get; set; }

        //Adicionar referencia para Paciente

        [Required(ErrorMessage = "Campo Paciente é obrigatorio!")]
        public Guid IdPaciente { get; set; }

        [ForeignKey(nameof(IdPaciente))]
        public Paciente? Paciente { get; set; }

        //Adicionar referencia para consulta

        [Required(ErrorMessage = "Campo Consulta é obrigatorio!")]
        public Guid IdConsulta { get; set; }

        [ForeignKey(nameof(IdConsulta))]
        public Consulta? Consulta { get; set; }
    }
}
