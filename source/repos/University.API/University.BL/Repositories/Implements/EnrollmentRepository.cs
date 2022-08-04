using University.BL.Data;
using University.BL.Models;

namespace University.BL.Repositories.Implements
{
    public class EnrollmentRepository : GenericRepository<Enrollment>
    {
        public EnrollmentRepository(UniversityContext universityContext) : base(universityContext)
        {

        }
    }
}
