using Health_Clinic.Domains;

namespace Health_Clinic.Interfaces
{
    public interface IPacienteRepository
    {
        void Cadastrar(Paciente paciente);

        List<Paciente> ListarTodos();

        void Atualizar(Guid id, Paciente paciente);

        void Deletar(Guid id);
    }
}
