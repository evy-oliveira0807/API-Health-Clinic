using Health_Clinic.Domains;
using Health_Clinic.Interfaces;

namespace Health_Clinic.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Usuario BuscarPorEmailESenha(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorId(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarUsuario(string? email, string? senha)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
