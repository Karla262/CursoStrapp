using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models = Empleado.WebAPI.Models;

namespace Empleado.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpleadosController : ControllerBase
    {

        public static List<Models.Empleado> list = new List<Models.Empleado>();

        private readonly ILogger<EmpleadosController> _logger;

        public EmpleadosController(ILogger<EmpleadosController> logger)
        {
            _logger = logger;

            Models.Empleado empleado1 = new Models.Empleado();
            empleado1.IdEmpleado = 1;
            empleado1.Nombre = "JUANIITO";
            empleado1.ApellidoPaterno = "PEREZ";
            empleado1.ApellidoMaterno = "PEREZ";
            empleado1.sexo = 'M';
            list.Add(empleado1);

            Models.Empleado empleado2 = new Models.Empleado();
            empleado2.IdEmpleado = 2;
            empleado2.Nombre = "MARÍA";
            empleado2.ApellidoPaterno = "HERNANDEZ";
            empleado2.ApellidoMaterno = "HERNANDEZ";
            empleado2.sexo = 'F';
            list.Add(empleado2);

        }

        [HttpGet]
        public List<Models.Empleado> Obtener()
        {
            return list;
        }

    }
}