

using Health_Clinic.Domains;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Health_Clinic.Domains
{

    [Table(nameof(Usuario))]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(150)")]
        [Required(ErrorMessage = "O nome do usuário é obrigatório")]
        public string? Nome { get; set; }

        [Column(TypeName = "VARCHAR(150)")]
        [Required(ErrorMessage = "O email é obrigatório")]
        public string? Email { get; set; }

        [Column(TypeName = "VARCHAR(60)")]
        [Required(ErrorMessage = "A senha é obrigatória")]
        public string? Senha { get; set; }

        [Required(ErrorMessage = "O ID do tipo de usuário é obrigatório")]
        public Guid IdTiposUsuario { get; set; }

        [ForeignKey(nameof(IdTiposUsuario))]
        public TiposUsuario? TiposUsuario { get; set; }
    }
}


