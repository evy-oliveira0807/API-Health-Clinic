using Health_Clinic.Domains;

namespace Health_Clinic.Interfaces
{
    public interface IComentarioRepository
    {
        void Cadastrar(Comentario comentario);

        void Atualizar(Guid id);
        void Deletar(Guid id);
    }
}
