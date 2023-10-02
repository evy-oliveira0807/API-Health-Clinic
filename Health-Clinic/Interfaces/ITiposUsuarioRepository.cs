using Health_Clinic.Domains;

namespace Health_Clinic.Interfaces
{
    public interface ITiposUsuarioRepository
    {
        void Cadastrar(TiposUsuario tiposUsuario);

        void Deletar(Guid id);

        List<TiposUsuario> Listar();

    }
}
