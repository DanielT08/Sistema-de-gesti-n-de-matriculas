using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solucion.Services.Enrollments;
using Microsoft.AspNetCore.Mvc;

namespace solucion.Controllers.Enrollments
{
    public class EnrollmentController: ControllerBase{
        public readonly IEnrollmentService _service;
        public EnrollmentController(IEnrollmentService service){
            _service = service;
        }

        
    }
}