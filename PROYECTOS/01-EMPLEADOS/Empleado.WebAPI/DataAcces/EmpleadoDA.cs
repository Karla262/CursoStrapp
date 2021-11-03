using Models = Empleado.WebAPI.Models;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Linq;
using System;

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

            List<Models.Empleado> listaEmpleados = new List<Models.Empleado>();
            string cadenaConexion = configuration.GetConnectionString("EmpleadoConnection");
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {

                string query = "SELECT idEmpleado, idPersona, nombre, apellidoPaterno, apellidoMaterno, sexo, curp, " +
                               "telefono, correoElectronico, fechaNacimiento, nacionalidad, idDireccion, calle, " +
                                "numeroExterior, numeroInterior, colonia, municipio, estado, codigoPostal, RFC, " +
                                "puesto, fechaIngreso, salarioDiario, NSS, horario, totalFaltas, activo " +
                                "FROM Empleado";

                var resultado = db.Query(query).ToList();

                //Iteramos el resultao
                foreach (var elemento in resultado)
                {
                    Models.Empleado empleado = new Models.Empleado(elemento);
                    listaEmpleados.Add(empleado);
                }
            }
            return listaEmpleados;
        }
        public Models.Empleado Crear(Models.Empleado empleado)
        {

            int idEmpleado;
            //1.Inicio
            //2. Obtener la cadena de conexión
            string cadenaConexion = configuration.GetConnectionString("EmpleadoConnection");

            //3. Crear la conexión
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {

                //4. Crear el query para insertar
                string query = "INSERT INTO Empleado (idPersona, nombre, apellidoPaterno, apellidoMaterno, sexo, curp," +
                               "telefono, correoElectronico, fechaNacimiento, nacionalidad, idDireccion, calle," +
                               "numeroExterior, numeroInterior, colonia, municipio, estado, codigoPostal, RFC, puesto," +
                               "fechaIngreso, salarioDiario, NSS, horario, totalFaltas, activo)" +
                               "VALUES (@idPersona, @nombre, @apellidoPaterno, @apellidoMaterno, @sexo," +
                               "@curp, @telefono, @correoElectronico, @fechaNacimiento, @nacionalidad, @idDireccion, @calle," +
                               "@numeroExterior, @numeroInterior, @colonia, @municipio, @estado, @codigoPostal, @RFC," +
                               "@puesto, @fechaIngreso, @salarioDiario, @NSS, @horario, @totalFaltas, @activo)" +
                               "SELECT CAST(SCOPE_IDENTITY() as int) AS idEmpleado";

                //5. Obtenemos Parametros               
                object parametros = empleado.ObtenerParametros();

                //6. Ejecutar la consulta (query) con los parametros
                idEmpleado = db.QuerySingle<int>(query, parametros);

                //7.Retornamos idEmpleados generado en la base de datos.
                empleado.IdEmpleado = idEmpleado;
            }

            //8. Retornar el empleado de Models

            return empleado;
        }
    }
}