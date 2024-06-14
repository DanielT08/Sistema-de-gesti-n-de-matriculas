using System.Runtime.InteropServices;
using AutoMapper;
using solucion.Controllers.Teachers;
using solucion.DTOs;
using solucion.Models;

namespace solucion.Utils
{
    public class MappingProfile: Profile
    { 
        public  MappingProfile()
        {
            CreateMap<Course, CourseGetDto>();
            CreateMap<Course, CoursePutDto>();
            CreateMap<Course, CourseGetIdDto>();
            CreateMap<Course, EnrollmentGetCourseDto>();
            /* CreateMap<Course, CourseEnrollmentDateDto>(); */

            CreateMap<Enrollment, EnrollmentGetDto>();
            CreateMap<Enrollment, EnrollmentPostDto>();
            CreateMap<Enrollment, EnrollmentListStudent>();
            CreateMap<Enrollment, EnrollmentDate>();

            CreateMap<Student, StudentGetDto>();
            CreateMap<Student, StudentPostDto>();
            CreateMap<Student, EnrollmentGetDtoStudent>();
            CreateMap<Student, StudentEnrr>();
            CreateMap<Student, StudentBirthDate>();

            CreateMap<Teacher, TeacherGetDto>();
            CreateMap<Teacher, TeacherPostDto>();
            CreateMap<Teacher, CourseGetDtoTeacher>();
            CreateMap<Teacher, TeacherDate>();

        }
    }
}