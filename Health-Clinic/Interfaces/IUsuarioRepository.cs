using Health_Clinic.Domains;

namespace Health_Clinic.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuario);

        Usuario BuscarPorId(Usuario usuario);

        Usuario BuscarPorEmailESenha(string email, string senha);

        Usuario BuscarUsuario(string? email, string? senha);
    }
}
