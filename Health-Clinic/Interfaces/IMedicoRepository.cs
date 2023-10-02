using Health_Clinic.Domains;

namespace Health_Clinic.Interfaces
{
    public interface IMedicoRepository
    {
        void Cadastrar(Medico medico);

        List<Medico> ListarTodos();

        void Atualizar(Guid id, Medico medico);

        void Deletar(Guid Id);


    }
}
