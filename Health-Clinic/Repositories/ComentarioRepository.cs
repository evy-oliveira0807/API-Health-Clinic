using Health_Clinic.Contexts;

namespace Health_Clinic.Repositories
{
    public class ComentarioRepository
    {
        private readonly ClinicContext _clinicContext;

        public ComentarioRepository()
        {
            _clinicContext = new ClinicContext();
        }
    }
}
