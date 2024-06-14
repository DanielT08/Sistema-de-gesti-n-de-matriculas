using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solucion.DTOs;

namespace solucion.Services.Students
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentGetDto>> ListStudent();
        Task<StudentPostDto> CreateStudent(StudentPostDto createstudent);
        Task<StudentGetDto> StudentById(int id);
        Task<StudentPostDto> UpdateStudent(int id, StudentPostDto UpdateStudent);
        Task<IEnumerable<StudentEnrr>> EnrrolmentStudent(int id);
        Task<IEnumerable<StudentBirthDate>> BirthdateStudent(DateTime date);
    }
}