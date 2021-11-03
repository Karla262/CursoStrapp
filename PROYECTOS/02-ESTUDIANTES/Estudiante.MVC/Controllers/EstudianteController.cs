using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Estudiante.MVC.Models;

namespace Estudiante.MVC.Controllers
{
    public class EstudianteController : Controller
    {
        private readonly ILogger<EstudianteController> _logger;

        public EstudianteController(ILogger<EstudianteController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("Estudiante");
        }

         public IActionResult Registro()
        {
            return View("Estudiante");
        }
        public IActionResult Editar()
        {
            return View("Estudiante");
        }
        public IActionResult Consultar()
        {
            return View("Estudiante");
        }
    }
}
