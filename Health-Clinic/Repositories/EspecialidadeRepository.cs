using Health_Clinic.Contexts;
using Health_Clinic.Domains;
using Health_Clinic.Interfaces;

namespace Health_Clinic.Repositories
{
    public class EspecialidadeRepository : IEspecialidadeRepository
    {
        private readonly ClinicContext _clinicContext;

        public EspecialidadeRepository()
        {
            _clinicContext = new ClinicContext();
        }

        public void Cadastrar(Especialidade especialidade)
        {
            _clinicContext.Especialidade.Add(especialidade);
            _clinicContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            try
            {
                Especialidade especialidade = _clinicContext.Especialidade.FirstOrDefault(u => u.IdEspecialidade == id)!;

                _clinicContext.Especialidade.Remove(especialidade);

                _clinicContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Especialidade> Listar()
        {
            return _clinicContext.Especialidade.ToList();
        }
    }
}

