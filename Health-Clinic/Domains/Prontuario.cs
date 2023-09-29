using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Health_Clinic.Domains
{
    [Table(nameof(Prontuario))]
    public class Prontuario
    {

        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "TEXT")]
        public string? Descricao { get; set; }
    }
}
