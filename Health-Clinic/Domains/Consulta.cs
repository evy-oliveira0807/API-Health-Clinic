﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Health_Clinic.Domains
{
    [Table(nameof(Consulta))]
    public class Consulta
    {
        [Key]

        public Guid IdConsulta { get; set; } = Guid.NewGuid();

        [Column(TypeName = "TIME")]
        [Required(ErrorMessage = "A data da consulta é obrigatória!")]
        public TimeSpan DataConsulta { get; set; }

        [Column(TypeName = "TIME")]
        [Required(ErrorMessage = "O horário da consulta é obrigatório!")]
        public TimeSpan HorarioConsulta { get; set; }

        [Column(TypeName = "VARCHAR(256)")]
        [Required(ErrorMessage = "O médico precisa fornecer o prontuário da consulta!")]
        public string? Prontuário { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "A descrisao da consulta e obrigatoria!")]

        public string? DescricaoConsulta { get; set;}

        [Required(ErrorMessage = "Campo paciente é obrigatorio!")]
        public Guid IdPaciente { get; set; }

        [ForeignKey(nameof(IdPaciente))]
        public Paciente? PacienteConsulta { get; set; }

        [Required(ErrorMessage = "Campo médico é obrigatorio!")]
        public Guid IdMedico { get; set; }

        [ForeignKey(nameof(IdMedico))]
        public Medico? MedicoConsulta { get; set; }

        public Guid IdComentario { get; set; }

        [ForeignKey(nameof(IdComentario))]
        public Comentario? ComentarioConsulta { get; set; }
    }
}
