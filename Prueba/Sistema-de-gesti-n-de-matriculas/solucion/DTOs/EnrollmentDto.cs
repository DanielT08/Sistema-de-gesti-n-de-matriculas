using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solucion.DTOs
{
    //Este Dto lo utilzo para listar compleo y id
    public class EnrollmentGetDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public string? Status { get; set; }
        
    }

     //Este Dto lo utilzo para actualizar y crear
    public class EnrollmentPostDto
    {
        public DateTime Date { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public string? Status { get; set; }
        public EnrollmentGetCourseDto? Course { get; set; }
        public EnrollmentGetDtoStudent? Student { get; set; }
        
    }

    //Dto para listar las matriculas de un studiante
    public class EnrollmentListStudent
    {
        public int CourseId { get; set; }
        public EnrollmentGetCourseDto? Course { get; set; }
        public string? Status { get; set; }
        
    }

    //Dto para listar matriculas por fecha especifica
    public class EnrollmentDate
    {
        public CourseEnrollmentDateDto? Course { get; set; }
        public StudentBirthDate? Student { get; set; }
        public string? Status { get; set; }
        
    }

}