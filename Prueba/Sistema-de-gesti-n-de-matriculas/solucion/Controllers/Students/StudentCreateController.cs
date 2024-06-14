using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using solucion.DTOs;
using solucion.Services.Students;

namespace solucion.Controllers.Students
{
    public class StudentCreateController : ControllerBase
    {
        public readonly IStudentService _service;
        public StudentCreateController(IStudentService service)
        {
            _service = service;
        }

        [HttpPost("/students/")]
        public async Task<ActionResult> CreateStudent([FromBody] StudentPostDto createstudent)
        {
            await _service.CreateStudent(createstudent);

            try
            {
                var response = new
                {
                    Confirmation = "Estudiando creado satisfactoriamente",
                    Student = createstudent

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