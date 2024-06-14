using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using solucion.DTOs;
using solucion.Repository.Courses;
using solucion.Services.Courses;

namespace solucion.Controllers.Courses
{
    public class CourseCreateController : ControllerBase
    {
        public readonly ICourseService _service;
        public CourseCreateController(ICourseService service)
        {
            _service = service;
        }

        [HttpPost("/courses/")]
        public async Task<ActionResult> CreateCourse([FromBody] CoursePutDto coursePutDto)
        {
            await _service.CreateCourse(coursePutDto);

            try
            {
                var response = new
                {
                    Confirmation = "Curso creado satisfactoriamente",
                    Course = coursePutDto

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