using Health_Clinic.Domains;

namespace Health_Clinic.Interfaces
{
    public interface IEspecialidadeRepository
    {
        void Cadastrar(Especialidade especialidade);

        void Deletar(Guid id);
    }
}
