using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solucion.DTOs;
using solucion.Repository.Courses;

namespace solucion.Services.Courses
{
    public class CourseService: ICourseService
    {
    
        public readonly ICourseRepository _repository;
        public CourseService(ICourseRepository repository){
            _repository = repository;
        }

        public Task<CourseGetIdDto> CourseById(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<CoursePutDto> CreateCourse(CoursePutDto coursePutDto)
        {
            return await _repository.CreateCourse(coursePutDto);
        }

        public Task<IEnumerable<CourseGetDto>> ListCourses()
        {
            throw new NotImplementedException();
        }

        public Task<CoursePutDto> UpdateCourse(int id, CoursePutDto UpdateCourse)
        {
            throw new NotImplementedException();
        }
    }
}