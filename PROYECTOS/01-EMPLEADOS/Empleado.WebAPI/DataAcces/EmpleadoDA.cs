using Models = Empleado.WebAPI.Models;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace Empleado.WebAPI.DataAcces
{

    public class EmpleadoDA
    {
        private readonly IConfiguration configuration;

        public EmpleadoDA(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public List<Models.Empleado> ObtenerEmpleados()
        {

            List<Models.Empleado> empleados = new List<Models.Empleado>();
            string cadenaConexion = configuration.GetConnectionString("EmpleadoConnection");
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {

                string query = "SELECT idEmpleado, idPersona, nombre, apellidoPaterno, apellidoMaterno, sexo, curp, " +
                               "telefono, correoElectronico, fechaNacimiento, nacionalidad, idDireccion, calle, " +
                                "numeroExterior, numeroInterior, colonia, municipio, estado, codigoPostal, RFC, " +
                                "puesto, fechaIngreso, salarioDiario, NSS, horario, totalFaltas, activo " +
                                "FROM Empleado";

                empleados = db.Query<Models.Empleado>(query).ToList();
            }
            return empleados;
        }
    }
}