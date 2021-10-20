using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcDapper.Models;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;


namespace MvcDapper.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly IConfiguration configuration;

        public CustomerController(ILogger<CustomerController> logger, IConfiguration config)
        {
            _logger = logger;
            configuration = config;
        }

        public IActionResult Index()
        {
            List<Customer> customers = new List<Customer>();
            string cadenaConexion = configuration.GetConnectionString("CustomerConnection");
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                
                customers = db.Query<Customer>("Select * From Customers").ToList();
            }
            return View(customers);
        }
    }
}
