using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solucion.DTOs;

namespace solucion.Services.Courses
{
    public interface ICourseService
    {
        Task<IEnumerable<CourseGetDto>> ListCourses();
        Task<CoursePutDto> CreateCourse(CoursePutDto coursePutDto);
        Task<CourseGetIdDto> CourseById(int Id);
        Task<CoursePutDto> UpdateCourse(int id, CoursePutDto UpdateCourse);
    }
}