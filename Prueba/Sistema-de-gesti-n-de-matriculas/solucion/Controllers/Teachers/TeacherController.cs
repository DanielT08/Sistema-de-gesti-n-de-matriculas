using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using solucion.Services.Teachers;

namespace solucion.Controllers.Teachers
{
    public class TeacherController: ControllerBase
    {
        public readonly ITeacherService _service;
        public TeacherController(ITeacherService service){
            _service = service;
        }
    }
}