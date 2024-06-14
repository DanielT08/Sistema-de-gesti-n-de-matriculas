using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solucion.DTOs;
using solucion.Repository.Students;

namespace solucion.Services.Students
{
    public class StudentService: IStudentService
    {
         public readonly IStudentRepository _repository;
        public StudentService(IStudentRepository repository){
            _repository = repository;
        }

        public Task<IEnumerable<StudentBirthDate>> BirthdateStudent(DateTime date)
        {
            throw new NotImplementedException();
        }

        public async Task<StudentPostDto> CreateStudent(StudentPostDto createstudent)
        {
            return await _repository.CreateStudent(createstudent);
        }

        public Task<IEnumerable<StudentEnrr>> EnrrolmentStudent(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<StudentGetDto>> ListStudent()
        {
            return await _repository.ListStudent();
        }

        public async Task<StudentGetDto> StudentById(int id)
        {
            return await _repository.StudentById(id);
        }

        public async Task<StudentPostDto> UpdateStudent(int id, StudentPostDto UpdateStudent)
        {
            return await _repository.UpdateStudent(id, UpdateStudent);
        }
    }
}