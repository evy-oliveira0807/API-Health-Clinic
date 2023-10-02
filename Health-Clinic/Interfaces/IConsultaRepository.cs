using Health_Clinic.Domains;

namespace Health_Clinic.Interfaces
{
    public interface IConsultaRepository
    {
        void Cadastrar(Consulta consulta);

        void Atualizar(Guid id, Consulta consulta);

        void Deletar(Guid id);
    }
}
