using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solucion.DTOs
{
    //Este Dto lo utilzo para listar compleo y por id
    public class TeacherGetDto
    {
        public int Id { get; set; }
        public string? Names { get; set; }
        public string? Specialty { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public int YearsExperience { get; set; }

    }
        //Este Dto lo utilzo para Actualizar y crear 
     public class TeacherPostDto
    {
        public string? Names { get; set; }
        public string? Specialty { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public int YearsExperience { get; set; }

    }

    //Dto para listar el nombre en los cursos
    public class CourseGetDtoTeacher
    {
        public string? Names { get; set; }
       
    }
    // dto para listar los cursos del profesor
     public class TeacherDate
    {
        public string? Names { get; set; }
        public ICollection<EnrollmentGetCourseDto>? Courses { get; set; }

    }
}