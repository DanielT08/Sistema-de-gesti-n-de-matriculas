using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solucion.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public string? Status { get; set; }
        public Course? Course { get; set; }
        public Student? Student { get; set; }
        
    }
}