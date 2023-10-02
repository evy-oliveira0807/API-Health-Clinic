using Health_Clinic.Domains;

namespace Health_Clinic.Interfaces
{
    public interface IProntuarioRepository
    {
        public void Cadastrar(Prontuario prontuario);

        public List<Prontuario> Listar(Guid id);

        public void Delete(Guid id);

        
    }
}
