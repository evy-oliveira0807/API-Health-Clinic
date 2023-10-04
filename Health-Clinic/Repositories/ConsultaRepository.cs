using Health_Clinic.Contexts;
using Health_Clinic.Domains;
using Health_Clinic.Interfaces;

namespace Health_Clinic.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        private readonly ClinicContext _clinicContext;

        public ConsultaRepository()
        {
            _clinicContext = new ClinicContext();
        }
        public void Atualizar(Guid id, Consulta consulta)
        {

            Consulta consultaBuscada = _clinicContext.Consulta.Find(id);

            if (consultaBuscada == null)
            {
                consultaBuscada.DataConsulta = consulta.DataConsulta;
                consultaBuscada.HorarioConsulta = consulta.HorarioConsulta;
                consultaBuscada.Prontuário = consulta.Prontuário;
                consultaBuscada.DescricaoConsulta = consulta.DescricaoConsulta;
                consultaBuscada.IdConsulta = consulta.IdConsulta;               
                consultaBuscada.IdMedico = consulta.IdMedico;
             
                              }
            _clinicContext.Consulta.Update(consultaBuscada);
            _clinicContext.SaveChanges();
        }

        public void Cadastrar(Consulta consulta)
        {
            _clinicContext.Consulta.Add(consulta);
            _clinicContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            try
            {
                Consulta consulta = _clinicContext.Consulta.FirstOrDefault(u => u.IdConsulta == id)!;

                _clinicContext.Consulta.Remove(consulta);

                _clinicContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}


