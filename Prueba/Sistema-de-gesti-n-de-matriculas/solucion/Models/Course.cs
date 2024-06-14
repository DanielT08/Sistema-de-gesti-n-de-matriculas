using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solucion.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Descripcion { get; set; }
        public int TeacherId { get; set; }
        public string? Schedule { get; set; }
        public string? Duration { get; set; }
        public string? Capacity { get; set; }
        public Teacher? Teacher { get; set; }
    }
}