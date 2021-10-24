using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models = Empleado.WebAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.Extensions.Configuration;
using Empleado.WebAPI.DataAcces;


namespace Empleado.WebAPI.Controllers
{
    [EnableCors("Mycors")]
    [ApiController]
    [Route("[controller]")]
    public class EmpleadosController : ControllerBase
    {

        public static List<Models.Empleado> listEmpleado = new List<Models.Empleado>()
        {
            new Models.Empleado()
            {
            IdEmpleado = 1,
            Nombre = "JUANIITO",
            ApellidoPaterno = "PEREZ",
            ApellidoMaterno = "PEREZ",
            Sexo = 'M',
            Activo = true,
            Puesto = "GERENTE DE OPERACIONES",
            Telefono = "2222498091",
            CorreoElectronico = "juanito.perez@correo.com"
            },

            new Models.Empleado()
            {
            IdEmpleado = 2,
            Nombre = "MARÍA",
            ApellidoPaterno = "HERNANDEZ",
            ApellidoMaterno = "HERNANDEZ",
            Sexo = 'F',
            Activo = true,
            Puesto = "GERENTE DE ADMINISTRACION",
            Telefono = "3332897451",
            CorreoElectronico = "maria.hernandez@correo.com"
            }
        };


        private readonly ILogger<EmpleadosController> _logger;

        private readonly IConfiguration _configuration;

        private readonly EmpleadoDA empleadoDA;

        public EmpleadosController(ILogger<EmpleadosController> logger,
                                    IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
            this.empleadoDA = new EmpleadoDA(_configuration);
        }

        [HttpGet]
        public List<Models.Empleado> Obtener()
        {
            //1. INICIO
            //2.DECLARA VARIABLE PARA LA LISTA DE EMPLEADOS ACTIVOS
            List<Models.Empleado> listaEmpleadosActivos = new List<Models.Empleado>();
            //3.OBTENER LISTA DE EMPLEADOS
            List<Models.Empleado> lista = empleadoDA.ObtenerEmpleados();
            //4.BUSCAR EMPLEADOS ACTIVOS (RECORRER LA LISTA DE EMPLEADOS)
            foreach (var empleado in lista)
            {
                //4.1. SI EMPLEADO QUE SE ESTA ITERANDO ESTA ACTIVO
                if (empleado.Activo == true)
                {
                    //4.1.1 AGREGAR EL EMPLEADO QUE SE ESTA ITERANDO A LA LISTA DE EMPLEADOS ACTIVOS
                    listaEmpleadosActivos.Add(empleado);
                }
            }
            //7.RETORNAR LISTA DE EMPLEADOS ACTIVOS
            return listaEmpleadosActivos;
            //8.FIN
        }


        [HttpPost]
        public async Task<ActionResult<Models.Empleado>> Crear(Models.Empleado empleado)
        {
            int number;
            bool parseoExitoso = int.TryParse(empleado.Direccion.CodigoPostal, out number);
            if (parseoExitoso == false)
            {
                return BadRequest();
            }

            //OBTENER EL ULTIMO EMPLEADO DE LA LISTA
            Models.Empleado ultimoEmpleado = listEmpleado.Last();
            //LE ASIGNAMOS EL ULTIMO ID
            empleado.IdEmpleado = ultimoEmpleado.IdEmpleado + 1;
            //activamos al empleado
            empleado.Activo = true;
            //AL NUEVO EMPLEADO LO AGREGAMOS A LA LISTA
            listEmpleado.Add(empleado);
            //RETORNAMOS AL EMPELADO AGREGADO
            return empleado;
        }



        [HttpPut]
        public async Task<ActionResult<Models.Empleado>> Actualizar(Models.Empleado empleado)
        {
            //1. INICIO

            // DECLARACION DE VARIABLE PARA EL EMPLEADO A MODFICAR 
            Models.Empleado empleadoModificar = null;

            //2. OBTENER LA LISTA
            List<Models.Empleado> listaEmp = listEmpleado;

            //3. RECIBIR EL PARAMETRO DE LOS DATOS NUEVOS DEL EMPLEADO (OBJETO EMPLEADO)

            //4. BUSCAR AL EMPLEADO DENTRO DE LA LISTA POR ID DE EMPLEADOA A MODIFICAR
            foreach (Models.Empleado iEmpleado in listaEmp)
            {
                //4.1 SI idEmpleado QUE SE ESTA ITERANDO ES IGUAL idEmpleado que se va a modificar (objeto empleado)
                if (iEmpleado.IdEmpleado == empleado.IdEmpleado)
                {
                    //OBTENER ESTE EMPLEADO PARA MODIFICAR
                    empleadoModificar = iEmpleado;
                    break;
                }

            }

            //6. SI EL EMPLEADO NO FUE ENCONTRADO
            if (empleadoModificar == null)
            {
                //REGREASAR UN ERROR DE EMPLEADO NO ENCONTRADO
                return NotFound();
            }
            else
            {
                //5. SI EL EMPLEADO FUE ENCONTRADO
                //5.1 MODIFICAR LOS DATOS DEL EMPLEADO ENCONTRADO CON LOS DATOS NUEVOS DEL EMPLEADO
                empleadoModificar.IdEmpleado = empleado.IdEmpleado;
                empleadoModificar.RFC = empleado.RFC;
                empleadoModificar.Puesto = empleado.Puesto;
                empleadoModificar.FechaIngreso = empleado.FechaIngreso;
                empleadoModificar.SalarioDiario = empleado.SalarioDiario;
                empleadoModificar.NSS = empleado.NSS;
                empleadoModificar.Horario = empleado.Horario;
                empleadoModificar.TotalFaltas = empleado.TotalFaltas;
                empleadoModificar.Activo = empleado.Activo;
                empleadoModificar.IdPersona = empleado.IdPersona;
                empleadoModificar.ApellidoPaterno = empleado.ApellidoPaterno;
                empleadoModificar.ApellidoMaterno = empleado.ApellidoMaterno;
                empleadoModificar.Sexo = empleado.Sexo;
                empleadoModificar.CURP = empleado.CURP;
                empleadoModificar.Telefono = empleado.Telefono;
                empleadoModificar.CorreoElectronico = empleado.CorreoElectronico;
                empleadoModificar.FechaNacimiento = empleado.FechaNacimiento;
                empleadoModificar.Nacionalidad = empleado.Nacionalidad;
                empleadoModificar.Direccion = empleado.Direccion;


            }

            //6. REGRESA EL EMPLEADO MOFICICADO
            return empleadoModificar;


        }

        [HttpGet]
        public async Task<ActionResult<Models.Empleado>> ObtenerPorIdEmpleado(int IdEmpleado)
        {
            //1. INICIO
            //2. DECLARAR LA VARIABLE EMPLEADOENCONTRADO
            Models.Empleado empleadoEncontrado = null;
            //3. RECIBIR PARAMETRO idEmpleado (A BUSCAR)

            //4. OBTENER LA LISTA
            List<Models.Empleado> Lista = listEmpleado;

            //5. BUSCA EL EMPLEADO POR idEmpleado EN LA LISTA EMPLEADO
            foreach (Models.Empleado iEmpleado in listEmpleado)
            {
                //5.1SI EL idEmpleado QUE SE ESTA ITERANDO ES IGUAL AL idEmpleado QUE SE RECIBIO POR PARMETRO
                if (iEmpleado.IdEmpleado == IdEmpleado)
                {
                    //OBTENER EL EMPLEADO A RETORNAR
                    empleadoEncontrado = iEmpleado;
                }
            }

            //6. SI EL EMPLEADO NO FUE ENCONTRADO
            if (empleadoEncontrado == null)
            {
                //6.1REGRESAR RESPUESTA DE EMPLEADO NO ENCONTRADO
                return NotFound();
            }
            else
            {
                //7. SI EL EMPLEADO FUE ENCONTRADO 
                //7.1 REGRESA AL EMPELADO
                return empleadoEncontrado;
            }
            //8. FIN
        }

        [HttpDelete]
        public async Task<ActionResult<Models.Empleado>> Eliminar(int IdEmpleado)
        {
            //1.INICIO
            //2. RECIBIMOS EL PARAMETRP DEL EMPLEADO QUE SE DESEA ELIMINAR
            //3. DECLARA VARIABLE EL EMPLEADO A ELIMINAR
            Models.Empleado empleadoEliminar = null;
            //4. OBTENER LISTA
            List<Models.Empleado> lista = listEmpleado;
            //5. BUSCAR AL EMPLEADO A ELIMINAR (RECORRER LA LISTA)
            foreach (var empleado in lista)
            {
                //5.1 SI EL idEmpleado DEL EMPLEADO QUE SE ITERA ES IGUAL AL idEmpleado DEL PARAMETRO
                if (empleado.IdEmpleado == IdEmpleado)
                {
                    //5.2 ASIGNAR EMPLEADO QUE SE DESEA ELIMINAR
                    empleadoEliminar = empleado;
                    break;
                }

            }
            //6. SI EL EMPLEADO A ELIMINAR NO SE ENCONTRO
            if (empleadoEliminar == null)
            {
                //6.3 REGRESA EL ELEMENTO NO ENCONTRADO
                return NotFound();
            }
            //7. SI EL EMPLEADO A ELIMINAR SI SE ENCONTRO
            if (empleadoEliminar != null)
            {
                //7.1 DESACTIVA EL EMPLEADO QUE SE DESEA ELIMINAR
                empleadoEliminar.Activo = false;
            }
            //7. REGRESAR EL EMPLEADO ELIMINADO
            //8.FIN
            return empleadoEliminar;
        }
    }
}