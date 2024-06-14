using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using solucion.Data;
using solucion.DTOs;

namespace solucion.Repository.Enrollments
{
    public class EnrollmentRepository: IEnrollmentRepository
    {
        public readonly BaseContext _context;
        public readonly IMapper _mapper;
        public EnrollmentRepository(BaseContext context, IMapper mapper ){
            _context = context;
            _mapper = mapper;
        }

        public Task<EnrollmentPostDto> CreateEnrollment(EnrollmentPostDto createEnrollment)
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

        public Task<EnrollmentPostDto> UpdateEnrollment(EnrollmentPostDto UpdateEnrollment)
        {
            throw new NotImplementedException();
        }
    }
}