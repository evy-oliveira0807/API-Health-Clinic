using Health_Clinic.Contexts;
using Health_Clinic.Domains;
using Health_Clinic.Interfaces;

namespace Health_Clinic.Repositories
{
    public class ProntuarioRepository : IProntuarioRepository
    {
        private readonly ClinicContext _clinicContext;

        public ProntuarioRepository()
        {
            _clinicContext = new ClinicContext();
        }
      
        public void Cadastrar(Prontuario prontuario)
        {
            try
            {
                prontuario.IdProntuario = Guid.NewGuid();
                _clinicContext.Prontuario.Add(prontuario);

                _clinicContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(Guid id)
        {
            Prontuario ProntuarioBuscado = _clinicContext.Prontuario.Find(id);

            _clinicContext.Prontuario.Remove(ProntuarioBuscado);

            _clinicContext.SaveChanges();
        }

        public List<Prontuario> Listar(Guid id)
        {
            try
            {
                return _clinicContext.Prontuario.ToList();
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
