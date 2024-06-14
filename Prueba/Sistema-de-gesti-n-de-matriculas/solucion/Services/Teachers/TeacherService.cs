using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solucion.DTOs;
using solucion.Repository.Teachers;

namespace solucion.Services.Teachers
{
    public class TeacherService: ITeacherService
    {
         public readonly ITeacherRepository _repository;
        public TeacherService(ITeacherRepository repository){
            _repository = repository;
        }

        public async Task<TeacherPostDto> CreateTeacher(TeacherPostDto teacherPostDtoken)
        {
            return await _repository.CreateTeacher(teacherPostDtoken);
        }

        public Task<IEnumerable<TeacherGetDto>> ListTeacher()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TeacherDate>> ListTeacherDate(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TeacherGetDto> StudentById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TeacherPostDto> UpdateTeacher(int id, TeacherPostDto teacherPostDto)
        {
            throw new NotImplementedException();
        }
    }
}