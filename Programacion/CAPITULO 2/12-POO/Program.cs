using System;

namespace _12_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creación de un objeto persona 
            Persona persona1 = new Persona();
            persona1.IdPersona = 1;
            persona1.Nombre = "Juanito"; 
            persona1.ApellidoPaterno ="Perez";
            persona1.ApellidoMaterno ="Perez";
            persona1.CorreoElectronico = "juanito@hotmail.com";
            persona1.CURP = "PEPJ20210412HTPDJDJD";
            persona1.FechaNacimiento = new Datetime(1999, 1, 20);
            persona1.Nacionalidad = "MEXICANA"; 
            persona1.Sexo = 'M';
            persona1.Telefono = " 5578963214";
           

            //Se inicializa primero el objeto dirección
            persona1.Direccion = new Direccion();
            persona1.Direccion.Calle = "Av Coyoacan";
            persona1.Direccion.NumeroExterior = "1035";
            persona1.Direccion.NumeroInterior = "11";

            int edad = persona1.ObtenerEdad();

            //cREACION DE UN EMLPLEADO
            Empleado empleado1 = new Empleado();
            empleado1.IdPersona = 1;
            empleado1.IdEmpleado = 1;
            empleado1.Nombre = "Juanito"; 
            empleado1.ApellidoPaterno ="Perez";
            empleado1.ApellidoMaterno ="Perez";
            empleado1.CorreoElectronico = "juanito@hotmail.com";
            empleado1.CURP = "PEPJ20210412HTPDJDJD";
            empleado1.FechaNacimiento = new Datetime(1999, 1, 20);
            empleado1.Nacionalidad = "MEXICANA"; 
            empleado1.Sexo = 'M';
            empleado1.Telefono = " 5578963214";
            empleado1.FechaIngreso = new Datetime(2021, 1, 1);
            empleado1.Horario = "8-3";
            empleado1.NumeroSeguroSocial = "124-28-96";
            empleado1.Puesto = "PROGRAMADOR";
            empleado1.RFC = "PEPJ202104";
            empleado1.SalarioDiario = "400";
            empleado1.TotalFaltas = 0;
            
            //Se inicializa primero el objeto dirección
            empleado1.Direccion = new Direccion();
            empleado1.Direccion.Calle = "Av. Coyoacan";
            empleado1.Direccion.NumeroExterior = "1035";
            empleado1.Direccion.NumeroInterior = "11";

            int edadEmpleado = empleado1.ObtenerEdad();
            int antiguedad = empleado1.ObtenerAntiguedad();
        }
    }
    public class Persona
    {
        public int IdPersona { get; set;}
        public string Nombre { get; set;}
        public string ApellidoPaterno { get; set;}
        public string ApellidoMaterno { get; set;}
        public char Sexo { get; set;}
        public string CURP { get; set;}
        public string Telefono { get; set;}
        public string CorreoElectronico { get; set;}
        public Datetime FechaNacimiento {get; set;}
        public string Nacionalidad { get; set;}
        public Direccion Direccion { get; set;}
        public int ObtenerEdad(){
            //ALGORITMO CALCULAR EDAD
            //.........
            int edad = 20; //Este se calcula con el algoritmo
            retunr edad;
        }
    }

    public class Direccion
    {
        public int IdDireccion { get; set;}
        public string Calle { get; set;}
        public string NumeroExterior { get; set;}
        public string NumeroInterior { get; set;}
        public string Colonia { get; set;}
        public string Municipio { get; set;}
        public string Estado { get; set;}
        public string CodigoPostal { get; set;}
    }
    public class Empleado: Persona
    {
        public int IdEmpleado {get; set;}
        public string RFC {get; set;}
        public string Puesto {get; set;}
        public Datetime FechaIngreso {get; set;}
        public decimal SalarioDiario {get; set;}
        public string NumeroSeguroSocial {get; set;}
        public string Horario {get; set;}
        public int TotalFaltas {get; set;}

        public int ObtenerAntiguedad()
        {
            //ALGORITMO CALCULAR ANTIGUEDAD TOMANDO LA FECHA DE INGRESO
            //.........
            //this.FechaIngreso = "2021-09-14";
            int antiguedad = 10; //Este se calcula con el algoritmo
            retunr antiguedad;
        }

        public void Registra()
        {

        }

        public void Actualiza()
        {

        }

        public void Eliminar()
        {

        }

    }
}
