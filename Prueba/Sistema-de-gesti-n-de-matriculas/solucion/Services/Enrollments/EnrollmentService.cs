using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solucion.DTOs;
using solucion.Repository.Enrollments;

namespace solucion.Services.Enrollments
{
    public class EnrollmentService: IEnrollmentService
    {
         public readonly IEnrollmentRepository _repository;
        public EnrollmentService(IEnrollmentRepository repository){
            _repository = repository;
        }

        public Task<EnrollmentPostDto> CreateEnrollment(EnrollmentPostDto enrollmentPostDto)
        {
            throw new NotImplementedException();
        }

        public Task<EnrollmentGetDto> EnrollmentById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EnrollmentDate>> ErollmentByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EnrollmentGetDto>> ListEnrollment()
        {
            throw new NotImplementedException();
        }

        public Task<EnrollmentPostDto> UpdateEnrollment(EnrollmentPostDto enrollmentPostDto)
        {
            throw new NotImplementedException();
        }
    }
}