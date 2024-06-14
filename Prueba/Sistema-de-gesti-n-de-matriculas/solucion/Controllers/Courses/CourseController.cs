using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using solucion.Repository.Courses;
using solucion.Services.Courses;

namespace solucion.Controllers.Courses
{
    public class CourseController: ControllerBase{

    public readonly ICourseService _service;
    public CourseController(ICourseService service){
        _service = service;
    }
    }
}