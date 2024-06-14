using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using solucion.DTOs;
using solucion.Services.Teachers;

namespace solucion.Controllers.Teachers
{
    public class TeacherCreateController: ControllerBase
    {
        public readonly ITeacherService _service;
        public TeacherCreateController(ITeacherService service){
            _service = service;
        }

        [HttpPost("/teachers/")]
        public async Task<IActionResult> createTeacher([FromBody] TeacherPostDto teacherPostDto){
            await _service.CreateTeacher(teacherPostDto);

          try
            {
                var response = new
                {
                    Confirmation = "Profesor creado satisfactoriamente",
                    Teacher = teacherPostDto

                };
                return Ok(response);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
