using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using solucion.DTOs;
using solucion.Repository.Students;
using solucion.Services.Students;

namespace solucion.Controllers.Students
{
    public class StudentController: ControllerBase
    {
        public readonly IStudentService _service;
        public StudentController(IStudentService service){
            _service = service;
        }

        [HttpGet("/students/")]
        public async Task<IEnumerable<StudentGetDto>> ListStudent(){
            var student = await _service.ListStudent();
            return student;
        }

        [HttpGet("/students/{id}")]
        public async Task<ActionResult<StudentGetDto>> StudentById(int id){

            var student = await _service.StudentById(id);
            if (student  != null)
            {
                return Ok(student);
            }

            return Ok("No se encontro un estudiante registrado con este Id");

        }

    }
}
