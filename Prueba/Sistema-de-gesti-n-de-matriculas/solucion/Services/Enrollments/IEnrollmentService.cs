using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solucion.DTOs;

namespace solucion.Services.Enrollments
{
    public interface IEnrollmentService
    {
        Task<IEnumerable<EnrollmentGetDto>> ListEnrollment();
        Task<EnrollmentPostDto> CreateEnrollment(EnrollmentPostDto enrollmentPostDto);
        Task<EnrollmentGetDto> EnrollmentById(int Id);
        Task<EnrollmentPostDto> UpdateEnrollment(EnrollmentPostDto enrollmentPostDto);
        Task<IEnumerable<EnrollmentDate>> ErollmentByDate(DateTime date);
    }
}