using Health_Clinic.Domains;

namespace Health_Clinic.Interfaces
{
    public interface IClinicaRepository
    {
        void Cadastrar(Clinica clinica);

        void Atualizar(Guid id, Clinica clinica);

        void Deletar(Guid id);
    }
}
