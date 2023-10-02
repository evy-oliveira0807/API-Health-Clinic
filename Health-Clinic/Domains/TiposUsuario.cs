using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Health_Clinic.Domains
{
    [Table(nameof(TiposUsuario))]
    public class TiposUsuario
    {
        [Key]
        public Guid IdTiposUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(60)")]
        [Required(ErrorMessage = "O titulo do tipo de usuário é obrigatório")]
        public string? Titulo { get; set; }
    }
}
