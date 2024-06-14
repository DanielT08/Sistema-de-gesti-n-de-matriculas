using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using solucion.DTOs;
using solucion.Models;
using solucion.Services.Students;

namespace solucion.Controllers.Students
{
    public class StudentUpdateController: ControllerBase
    {
         public readonly IStudentService _service;
        public StudentUpdateController(IStudentService service){
            _service = service;
        }

        [HttpPut("/students/{id}")]
        public async Task<IActionResult> UpdateStudent(int id, [FromBody] StudentPostDto UpdateStudent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            var student = await _service.UpdateStudent(id, UpdateStudent);
            if (UpdateStudent == null)
            {
                return NotFound("Estudiante no encontrado");
            }

            return Ok("Los datos fueron actualizados correctamente");
        }

        
    }
}