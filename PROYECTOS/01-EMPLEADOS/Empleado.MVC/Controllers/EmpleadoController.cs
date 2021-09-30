using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Empleado.MVC.Models;

namespace Empleado.MVC.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly ILogger<EmpleadoController> _logger;

        public EmpleadoController(ILogger<EmpleadoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Listado()
        {
            return View();
        }

        public IActionResult Registro()
        {
            return View("Empleado");
        }
        public IActionResult Editar()
        {
            return View("Empleado");
        }
        public IActionResult Consultar()
        {
            return View("Empleado");
        }
    }
}
