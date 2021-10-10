using System;
namespace Empleado.WebAPI.Models
{
    public class Persona
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public char Sexo { get; set; }
        public string CURP { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public Direccion Direccion { get; set; }
    }
}