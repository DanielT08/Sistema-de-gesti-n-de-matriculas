using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using solucion.Services.Enrollments;

namespace solucion.Controllers.Enrollments
{
    public class EnrollmentCreateController: ControllerBase
    {
        public readonly IEnrollmentService _service;
        public EnrollmentCreateController(IEnrollmentService service){
            _service = service;
        }
    }
}