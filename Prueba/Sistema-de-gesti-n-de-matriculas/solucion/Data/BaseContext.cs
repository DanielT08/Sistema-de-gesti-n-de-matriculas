using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using solucion.Models;

namespace solucion.Data
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base (options){}
        
        public DbSet<Course> courses { get; set; }
        public DbSet<Enrollment> enrollments { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Teacher> teachers { get; set; }

    }
}