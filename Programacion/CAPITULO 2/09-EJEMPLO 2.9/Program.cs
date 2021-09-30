using System;
using System.Collections.Generic;

namespace _09_EJEMPLO_2._9
{
    class Program
    {
        //1.- Definir una variable global llamda banco de datos
        static List<Empleado> bancoDeDatos = null;

        static void Main(string[] args)
        {

         //1.-Inicio 
             //2.- Mandar a llamar el CreaBancoDeDatos
             CreaBancoDeDatos();
             //3.- Mandar a llamar el registraEmpleado con los siguientes datos:
             // Numero: 1, Nombre: Juanito Pérez, Numero Horas Trabajadas: 55, Salario x hora: 180
             registraEmpleado(1, "Juanito Perez", 55, 180);

             //4.- Mandar a llamar el registraEmpleado con los siguientes datos:
             // Numero: 2, Nombre: Daniel Perez, Numero Horas Trabajadas: 35, Salario x hora: 150
             registraEmpleado(2, "Daniel Perez", 35, 150);

             //5.- Mandar a llamar el registraEmpleado con los siguientes datos:
             // Numero: 3, Nombre: Fernando Gomez, Numero Horas Trabajadas: 40, Salario x hora: 200
             registraEmpleado(3, "Fernando Gomez", 40, 200);

             //6.- Mandar a llamar el registraEmpleado con los siguientes datos:
             // Numero: 4, Nombre: María Hernandez, Numero Horas Trabajadas: 0, Salario x hora: 300
             registraEmpleado(4, "María Hernandez", 0, 300);

             //7.- Mandar a llamar el registraEmpleado con los siguientes datos:
             // Numero: 5, Nombre: Pedro Salas, Numero Horas Trabajadas: 100, Salario x hora: 40
             registraEmpleado(5, "Pedro Salas", 100, 40);
             //Imprimir Encabezado
             ImprimirEncabezado();

             //8.- Recoorrer la lista de banco datos empelado
             foreach(Empleado empleado in bancoDeDatos)
             {    
                //Declarar las variables pagoHorasSemanal, pagoHorasExtraSemanal 
                int pagoHorasSemanal, pagoHorasExtraSemanal;
                //Declarar las variables pagoSemanal, pagoExtra, total
                decimal pagoSemanal, pagoExtra, total;
                //8.7 Si empleado horas trabajadas >40
                if(empleado.NumeroHorasTrabajadas > 40)
                {
                         //3.7.1 PagoHorasSemanal = 40
                         pagoHorasSemanal = 40;
                        //3.7.2 PagoHoras ExtraSemanal = empelado.HorasTrabajadas = 40
                        pagoHorasExtraSemanal = empleado.NumeroHorasTrabajadas - 40;
                }
                else
                {
                          //3.8.1 PagoHorasSemanal = empleado.HorasTrabajadas
                          pagoHorasSemanal = empleado.NumeroHorasTrabajadas;
                         //3.8.2PagoHorasEstraSemanal = 0
                         pagoHorasExtraSemanal = 0;
                }
                   
                //8.9PagoSemanal va a ser igual PagoHorasSemanal * empleado.SalarioxHora
                pagoSemanal = pagoHorasSemanal * empleado.SalarioPorHora;
                //8.10 PagoExtra va a ser igual PagoHorasExtraSemanal * empleado.SalarioXHora * 1.5
                pagoExtra = pagoHorasExtraSemanal * empleado.SalarioPorHora * 1.5m;
                //8.11 El total va a ser igual PagoHorasSemanal + PagoHorasExtraSemanal
                total = pagoSemanal + pagoExtra;
                //8.12 Imprimir los resultados
                ImprimirResultado(empleado, pagoHorasSemanal, pagoHorasExtraSemanal, pagoSemanal, pagoExtra, total);
                //9.- Fin
             }
        }
    

        static void registraEmpleado(int numeroEmpleado, string nombre, int numeroHorasTrabajadas, 
        decimal salarioPorHora)
        {
            //1.-Inicio
            //2.-recibe como parametro el numero de empleado, nombre, numero de horas trabajadas y salario por hora.
            //3.-Crear un objeto con los parametros recibidos
            Empleado empleado = new Empleado();
               
                //Registra el objeto empleado numero de empleado
                empleado.NumeroEmpleado = numeroEmpleado;
                //Registra el objeto empleado nombre
                empleado.Nombre = nombre;
                //Registra el objeto empleado numero de horas trabajadas
                empleado.NumeroHorasTrabajadas = numeroHorasTrabajadas;
                //Registra el objeto empleado Salario por hora
                empleado.SalarioPorHora = salarioPorHora;
                //4.-Agregar el objeto al banco de datos
                 bancoDeDatos.Add(empleado);
                //6.-Fin
        }
    

        static void CreaBancoDeDatos()
        {
            //1.-Inicio
            //2.-Crea banco de datos
                //2.0Definir a entidad empleados
                //2.1 Crear la lista banco de datos
                bancoDeDatos = new List<Empleado>();
            //3.-Fin
        }


        static void ImprimirResultado( Empleado empleado, 
                                      int pPagoHorasSemanal, 
                                      int pPagoHorasExtraSemanal, 
                                      decimal pPagoSemanal, 
                                      decimal pPagoExtra, 
                                      decimal pTotal)
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}", 
                                                          empleado.NumeroEmpleado,
                                                          empleado.Nombre,
                                                          empleado.NumeroHorasTrabajadas,
                                                          empleado.SalarioPorHora,
                                                          pPagoHorasSemanal,
                                                          pPagoHorasExtraSemanal,
                                                          pPagoSemanal,
                                                          pPagoExtra,
                                                          pTotal);

        }
            
            static void ImprimirEncabezado(){
                string tnumeroEmpleado = "Numero Empleado";
                string tnombre = "Nombre";
                string tnumeroHorasTrabajadas = "Número Horas Trabajadas";
                string tSalarioPorHora = "Salario por Hora";
                string pPagoHorasSemanal = "Pago Horas Semanal";
                string pPagoHorasExtraSemanal = "Pago Horas Extra Semanal"; 
                string pPagoSemanal = "Pago Semanal";
                string pPagoExtra = "Pago Extra";
                string pTotal = "Total"; 
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}", 
                                                             tnumeroEmpleado, 
                                                             tnombre, 
                                                             tnumeroHorasTrabajadas, 
                                                             tSalarioPorHora,
                                                             pPagoHorasSemanal,
                                                             pPagoHorasExtraSemanal,
                                                             pPagoSemanal,
                                                             pPagoExtra,
                                                             pTotal);
                Console.WriteLine("============================================================================================");
            }
    }    
        public class Empleado
        {
            public int NumeroEmpleado { get; set; }
            public string Nombre { get; set; }
            public int NumeroHorasTrabajadas { get; set; }
            public decimal SalarioPorHora { get; set; }
        
        }
}

