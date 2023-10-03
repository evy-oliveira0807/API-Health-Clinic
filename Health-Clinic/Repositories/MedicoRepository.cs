using Health_Clinic.Contexts;
using Health_Clinic.Domains;
using Health_Clinic.Interfaces;

namespace Health_Clinic.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly ClinicContext _clinicContext;

        public MedicoRepository()
        {
            _clinicContext = new ClinicContext();
        }

        public void Atualizar(Guid id, Medico medico)
        {

            Medico medicoBuscado = _clinicContext.Medico.Find(id);

            if (medicoBuscado == null)
            {
                medicoBuscado.NomeMedico = medico.NomeMedico;
                medicoBuscado.CRM = medico.CRM;
                medicoBuscado.IdClinica = medico.IdClinica;
                medicoBuscado.IdUsuario = medico.IdUsuario;
                medicoBuscado.IdEspecialidade = medico.IdEspecialidade;

            }
            _clinicContext.Medico.Update(medicoBuscado);
            _clinicContext.SaveChanges();

        }

        public void Cadastrar(Medico medico)
        {
            try
            {
                medico.IdMedico = Guid.NewGuid();
                _clinicContext.Medico.Add(medico);
                _clinicContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid Id)
        {


            Medico medicoBuscado = _clinicContext.Medico.Find(Id);

            _clinicContext.Medico.Remove(medicoBuscado);

            _clinicContext.SaveChanges();
        }

        public List<Medico> ListarTodos()
        {
            return _clinicContext.Medico.ToList();
        }
    }
}
