using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using solucion.Services.Courses;

namespace solucion.Controllers.Courses
{
    public class CourseUpdateController: ControllerBase
    {
        public readonly ICourseService _service;
    public CourseUpdateController(ICourseService service){
        _service = service;
    }
 
    }
}
