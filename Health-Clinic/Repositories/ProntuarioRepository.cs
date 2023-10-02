using Health_Clinic.Contexts;
using Health_Clinic.Domains;
using Health_Clinic.Interfaces;

namespace Health_Clinic.Repositories
{
    public class ProntuarioRepository : IProntuarioRepository
    {
        private readonly ClinicContext ctx;

        public ProntuarioRepository()
        {
            ctx = new ClinicContext();
        }
      
        public void Cadastrar(Prontuario prontuario)
        {
            try
            {
                prontuario.IdProntuario = Guid.NewGuid();
               ctx.Prontuario.Add(prontuario);

                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(Guid id)
        {
            Prontuario ProntuarioBuscado = ctx.Prontuario.Find(id);

            ctx.Prontuario.Remove(ProntuarioBuscado);

            ctx.SaveChanges();
        }

        public List<Prontuario> Listar(Guid id)
        {
            try
            {
                return ctx.Prontuario.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal object? Listar()
        {
            throw new NotImplementedException();
        }
    }
}
