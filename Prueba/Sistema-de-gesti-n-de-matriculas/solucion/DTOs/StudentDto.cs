using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solucion.DTOs
{
    //Este Dto lo utilzo para listar compleo y por id
     public class StudentGetDto
    {
        public int Id { get; set; }
        public string? Names { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
    }

    //Este Dto lo utilzo para Actualizar y crear 
     public class StudentPostDto
    {
        public string? Names { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
    }

    //Dto para listar el nombre del estudiante
    public class EnrollmentGetDtoStudent
    {
        public string? Name { get; set; }
    }

    //Dto para listar las matriculas de un estudiantes
    public class StudentEnrr
    {
        public string? Names { get; set; }
        public string? Email { get; set; }
        public ICollection<EnrollmentListStudent>? Enrollments { get; set; }
    }
    // dto para listar estudainte por fecha de cumpleaños
     public class StudentBirthDate
    {
        public string? Names { get; set; }
        public string? Email { get; set; }
    }

}