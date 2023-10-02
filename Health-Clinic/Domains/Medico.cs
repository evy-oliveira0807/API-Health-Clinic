﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Health_Clinic.Domains
{
    [Table(nameof(Medico))]
    public class Medico
    {
        [Key]
        public Guid IdMedico { get; set; } = Guid.NewGuid();


        [Column(TypeName = "VARCHAR(150)")]
        [Required(ErrorMessage = "O nome do Medico é obrigatório")]
        public string? NomeMedico { get; set; }

        [Column(TypeName = "VARCHAR(6)")]
        [Required(ErrorMessage = "O numero do CRM é obrigatório")]
        public string? CRM { get; set; }

        //ref.Tabela Clinica
        [Required(ErrorMessage = "O ID da clinica é obrigatório")]
        public Guid IdClinica { get; set; }

        [ForeignKey(nameof(IdClinica))]
        public Clinica? Clinica { get; set; }

        //ref.tabela Usuario
        [Required(ErrorMessage = "O ID do usuário é obrigatório")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }

        //ref.tabela Especialidade
        [Required(ErrorMessage = "O ID da especialidade é obrigatória")]
        public Guid IdEspecialidade { get; set; }

        [ForeignKey(nameof(IdEspecialidade))]
        public Especialidade? Especialidade { get; set; }
    }
}

