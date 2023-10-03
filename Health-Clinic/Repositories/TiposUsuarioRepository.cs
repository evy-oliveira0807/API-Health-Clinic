using Health_Clinic.Contexts;
using Health_Clinic.Domains;
using Health_Clinic.Interfaces;

namespace Health_Clinic.Repositories
{
    public class TiposUsuarioRepository : ITiposUsuarioRepository
    {

        
        private readonly ClinicContext _clinicContext;
        
        public TiposUsuarioRepository()
        {
            _clinicContext = new ClinicContext();
        }

        public void Cadastrar(TiposUsuario tiposUsuario)
        {
            try
            {
                tiposUsuario.IdTiposUsuario = Guid.NewGuid();

                _clinicContext.TiposUsuario.Add(tiposUsuario);

                _clinicContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            TiposUsuario TipousuarioBuscado = _clinicContext.TiposUsuario.Find(id);

            _clinicContext.TiposUsuario.Remove(TipousuarioBuscado);

            _clinicContext.SaveChanges();
        }

        public List<TiposUsuario> Listar()
        {
            try
            {
                return _clinicContext.TiposUsuario.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

       
         
    }
}

