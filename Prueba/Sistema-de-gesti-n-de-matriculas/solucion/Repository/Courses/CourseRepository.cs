using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using solucion.Data;
using solucion.DTOs;
using solucion.Models;

namespace solucion.Repository.Courses
{
    public class CourseRepository: ICourseRepository
    {
        public readonly BaseContext _context;
        public readonly IMapper _mapper;
        public CourseRepository(BaseContext context, IMapper mapper ){
            _context = context;
            _mapper = mapper;
        }

        public Task<CourseGetIdDto> CourseById(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<CoursePutDto> CreateCourse(CoursePutDto coursePutDto)
        {
              var course = new Course
            {
                Name = coursePutDto.Name,
                Descripcion = coursePutDto.Descripcion,
                TeacherId = coursePutDto.TeacherId,
                Schedule = coursePutDto.Schedule,
                Duration = coursePutDto.Duration,
                Capacity = coursePutDto.Capacity
            };
             
            await _context.courses.AddAsync(course);
            await _context.SaveChangesAsync();

            return  coursePutDto;
        }

        public Task<IEnumerable<CourseGetDto>> ListCourses()
        {
            throw new NotImplementedException();
        }

        public Task<CoursePutDto> UpdateStudent(int id, CoursePutDto UpdateStudent)
        {
            throw new NotImplementedException();
        }
    }
}