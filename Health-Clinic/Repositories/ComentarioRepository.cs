using Health_Clinic.Contexts;
using Health_Clinic.Domains;
using Health_Clinic.Interfaces;

namespace Health_Clinic.Repositories
{
    public class ComentarioRepository : IComentarioRepository
    {
        private readonly ClinicContext _clinicContext;

        public ComentarioRepository()
        {
            _clinicContext = new ClinicContext();
        }

        public void Atualizar(Guid id, Comentario comentario)
        {
            Comentario comentarioBuscada = _clinicContext.Comentario.Find(id);

            if (comentarioBuscada == null)
            {
                comentarioBuscada.Descricao = comentario.Descricao;
                comentarioBuscada.IdPaciente = comentario.IdPaciente;
                comentarioBuscada.IdConsulta = comentario.IdConsulta;
                                                     

            }
            _clinicContext.Comentario.Update(comentarioBuscada);
            _clinicContext.SaveChanges();
        }

        public void Cadastrar(Comentario comentario)
        {
            _clinicContext.Comentario.Add(comentario);
            _clinicContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            try
            {
                Comentario comentario = _clinicContext.Comentario.FirstOrDefault(u => u.IdComentario == id)!;

                _clinicContext.Comentario.Remove(comentario);

                _clinicContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
