using University.BL.Models;
using University.BL.Repositories;

namespace University.BL.Services.Implements
{
    public class EnrollmentService : GenericService<Enrollment>
    {
        public EnrollmentService(IEnrollmentRepository enrollemntRepository) : base(enrollemntRepository)
        {

        }
    }
}
