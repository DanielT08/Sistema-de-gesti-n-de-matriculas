using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solucion.DTOs
{
    //Este Dto lo utilzo para listar compleo, id 
    public class CourseGetDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Descripcion { get; set; }
        public int TeacherId { get; set; }
        public string? Schedule { get; set; }
        public string? Duration { get; set; }
        public string? Capacity { get; set; }
        public CourseGetDtoTeacher? Teacher { get; set; }
    }

    //Este Dto lo utilzo para listar por id
    public class CourseGetIdDto
    {
        public string? Name { get; set; }
        public string? Descripcion { get; set; }
        public string? Schedule { get; set; }
        public string? Duration { get; set; }
        public string? Capacity { get; set; }
    }
     //Este Dto lo utilzo para actualizar y crear
     public class CoursePutDto
    {
        public string? Name { get; set; }
        public string? Descripcion { get; set; }
        public int TeacherId { get; set; }
        public string? Schedule { get; set; }
        public string? Duration { get; set; }
        public string? Capacity { get; set; }
    }

    //Dto para listar el nombre del curso
    public class EnrollmentGetCourseDto
    {
        public string? Name { get; set; }
    }
    
     // dto para listar matriculas ne fecha especifica
    public class CourseEnrollmentDateDto
    {

        public string? Name { get; set; }
        public string? Descripcion { get; set; }
        public string? Schedule { get; set; }
        public string? Duration { get; set; }
        public CourseGetDtoTeacher? Teacher { get; set; }
    }
}