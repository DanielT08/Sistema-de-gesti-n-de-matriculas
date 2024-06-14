using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solucion.DTOs;

namespace solucion.Repository.Courses
{
    public interface ICourseRepository
    {
        Task<IEnumerable<CourseGetDto>> ListCourses();
        Task<CoursePutDto> CreateCourse(CoursePutDto  coursePutDto);
        Task<CourseGetIdDto> CourseById(int Id);
        Task<CoursePutDto> UpdateStudent(int id, CoursePutDto UpdateStudent);
    }
}