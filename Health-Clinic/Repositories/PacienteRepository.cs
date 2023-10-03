using Health_Clinic.Contexts;
using Health_Clinic.Controllers;
using Health_Clinic.Domains;
using Health_Clinic.Interfaces;

namespace Health_Clinic.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly ClinicContext _clinicContext;

        public PacienteRepository()
        {
            _clinicContext = new ClinicContext();
        }
        public void Atualizar(Guid id, Paciente paciente)
        {

            Paciente pacienteBuscado = _clinicContext.Paciente.Find(id);

            if (pacienteBuscado == null )
            {
                pacienteBuscado.Nome = paciente.Nome;
                pacienteBuscado.DataNascimento = paciente.DataNascimento;
                pacienteBuscado.RG = paciente.RG;
                pacienteBuscado.CPF = paciente.CPF;
                pacienteBuscado.Telefone = paciente.Telefone;
                pacienteBuscado.IdUsuario = paciente.IdUsuario;
              
            }
            _clinicContext.Paciente.Update(pacienteBuscado);

            _clinicContext.SaveChanges();

        }

        public void Cadastrar(Paciente paciente)
        {
            try
            {
                paciente.IdPaciente = Guid.NewGuid();
                _clinicContext.Paciente.Add(paciente);
                _clinicContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

        }public void Deletar(Guid id)
        {
       

            Paciente pacienteBuscado = _clinicContext.Paciente.Find(id);

            _clinicContext.Paciente.Remove(pacienteBuscado);

            _clinicContext.SaveChanges();
        }

        public List<Paciente> ListarTodos()
        {
            return _clinicContext.Paciente.ToList();
        }
    }

        
    }

