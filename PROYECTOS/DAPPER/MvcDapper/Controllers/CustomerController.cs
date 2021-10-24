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
using Microsoft.AspNetCore.Http;


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

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            Customer customer = new Customer();
            string cadenaConexion = configuration.GetConnectionString("CustomerConnection");
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                string query = "Select * From Customers WHERE CustomerID =" + id;
                customer = db.Query<Customer>(query, new { id }).SingleOrDefault();
            }

            return View(customer);
        }

        // GET: Customer/Create
            public ActionResult Create()
            {
                return View();
            }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            try
            {
                string cadenaConexion = configuration.GetConnectionString("CustomerConnection");
                using (IDbConnection db = new SqlConnection(cadenaConexion))
                {
                    string sqlQuery = "Insert Into Customers (FirstName, LastName, Email) Values(@FirstName, @LastName, @Email)";

                    int rowsAffected = db.Execute(sqlQuery, customer);
                }

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View();
            }
        }

                // GET: Customer/Edit/5
            public ActionResult Edit(int id)
            {
            Customer customer = new Customer();
            string cadenaConexion = configuration.GetConnectionString("CustomerConnection");
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                customer = db.Query<Customer>("Select * From Customers WHERE CustomerID =" + id, new { id }).SingleOrDefault();
            }
            return View(customer);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Customer customer)
        {
            try
            {
                string cadenaConexion = configuration.GetConnectionString("CustomerConnection");
                using (IDbConnection db = new SqlConnection(cadenaConexion))
                {
                    string sqlQuery = "UPDATE Customers set FirstName='" + customer.FirstName + 
                        "',LastName='" + customer.LastName + 
                        "',Email='" + customer.Email + 
                        "' WHERE CustomerID=" + customer.CustomerID;

                    int rowsAffected = db.Execute(sqlQuery);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

            // GET: Customer/Delete/5
            public ActionResult Delete(int id)
            {
                Customer customer = new Customer();
                string cadenaConexion = configuration.GetConnectionString("CustomerConnection");
                using (IDbConnection db = new SqlConnection(cadenaConexion))
                {
                    customer = db.Query<Customer>("Select * From Customers WHERE CustomerID =" + id, new { id }).SingleOrDefault();
                }
                return View(customer);
            }

            // POST: Customer/Delete/5
            [HttpPost]
            public ActionResult Delete(int id, IFormCollection collection)
            {
                try
                {
                    string cadenaConexion = configuration.GetConnectionString("CustomerConnection");
                    using (IDbConnection db = new SqlConnection(cadenaConexion))
                    {
                        string sqlQuery = "Delete From Customers WHERE CustomerID = " + id;

                        int rowsAffected = db.Execute(sqlQuery);
                    }

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }


    }
}
