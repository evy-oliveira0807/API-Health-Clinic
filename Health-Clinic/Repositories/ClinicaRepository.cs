using Health_Clinic.Contexts;
using Health_Clinic.Domains;
using Health_Clinic.Interfaces;

namespace Health_Clinic.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {

        private readonly ClinicContext _clinicContext;

        public ClinicaRepository()
        {
            _clinicContext = new ClinicContext();
        }
        public void Atualizar(Guid id, Clinica clinica)
        {
            Clinica clinicaBuscada = _clinicContext.Clinica.Find(id)!;

            if (clinicaBuscada != null)
            {
                clinicaBuscada.NomeFantasia = clinica.NomeFantasia;

                clinicaBuscada.RazaoSocial = clinica.RazaoSocial;

                clinicaBuscada.CNPJ = clinica.CNPJ;

                clinicaBuscada.Endereco = clinica.Endereco;

                clinicaBuscada.horarioAbertura = clinica.horarioAbertura;

                clinicaBuscada.horarioFechamento = clinica.horarioFechamento;

            }
            _clinicContext.Clinica.Update(clinicaBuscada);
            _clinicContext.SaveChanges();
        }

        public Clinica BuscarPorId(Guid id)
        {
            return _clinicContext.Clinica.FirstOrDefault(u => u.IdClinica == id)!;
        }

        public void Cadastrar(Clinica clinica)
        {
           _clinicContext.Clinica.Add(clinica);
            _clinicContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            try
            {
                Clinica clinica = _clinicContext.Clinica.FirstOrDefault(u => u.IdClinica == id)!;

                _clinicContext.Clinica.Remove(clinica);
                _clinicContext.SaveChanges();   
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Clinica> Listar()
        {
            return _clinicContext.Clinica.ToList();
        }
    }
}
