using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Health_Clinic.Migrations
{
    /// <inheritdoc />
    public partial class HealthClinic2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Medico");

            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "Medico");

            migrationBuilder.DropColumn(
                name: "RG",
                table: "Medico");

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Paciente",
                type: "VARCHAR(15)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "Paciente",
                type: "DATE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Paciente",
                type: "VARCHAR(200)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeMedico",
                table: "Medico",
                type: "VARCHAR(200)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescricaoConsulta",
                table: "Consulta",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "HorarioConsulta",
                table: "Consulta",
                type: "TIME",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<Guid>(
                name: "IdComentario",
                table: "Consulta",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "RazaoSocial",
                table: "Clinica",
                type: "VARCHAR(150)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_IdComentario",
                table: "Consulta",
                column: "IdComentario");

            migrationBuilder.AddForeignKey(
                name: "FK_Consulta_Comentario_IdComentario",
                table: "Consulta",
                column: "IdComentario",
                principalTable: "Comentario",
                principalColumn: "IdComentario",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consulta_Comentario_IdComentario",
                table: "Consulta");

            migrationBuilder.DropIndex(
                name: "IX_Consulta_IdComentario",
                table: "Consulta");

            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "NomeMedico",
                table: "Medico");

            migrationBuilder.DropColumn(
                name: "DescricaoConsulta",
                table: "Consulta");

            migrationBuilder.DropColumn(
                name: "HorarioConsulta",
                table: "Consulta");

            migrationBuilder.DropColumn(
                name: "IdComentario",
                table: "Consulta");

            migrationBuilder.DropColumn(
                name: "RazaoSocial",
                table: "Clinica");

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Usuario",
                type: "VARCHAR(15)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Medico",
                type: "VARCHAR(15)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "Medico",
                type: "SMALLDATETIME",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "RG",
                table: "Medico",
                type: "VARCHAR(15)",
                nullable: false,
                defaultValue: "");
        }
    }
}
