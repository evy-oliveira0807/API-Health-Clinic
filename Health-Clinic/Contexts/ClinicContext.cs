using Health_Clinic.Domains;
using Microsoft.EntityFrameworkCore;

namespace Health_Clinic.Contexts
{
    public class ClinicContext : DbContext
    {
        public DbSet<Clinica> Clinica { get; set; }
        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<Consulta> Consulta { get; set; }
        public DbSet<Especialidade> Especialidade { get; set; }
        public DbSet<Medico> Medico { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Prontuario> Prontuario { get; set; }
        public DbSet<TiposUsuario> TiposUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOTE11-S14; Database =HealthClinic_API; User id = sa; pwd = Senai@134; TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    
    }
}
