using System;
using System.Collections.Generic;
namespace _04_EJEMPLO_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.- Inicio
            //2.- Pedir el numero de cliente
            // Console.Write("Introduce el numero de Cliente:");
            //string entrada = Console.Read();
            int numeroCliente = 3;//int.Parse(entrada);

            //3.- Buscar al cliente dentro de la banco de datos -> Esto manda a llamar un subAlgoritmo 2
            Cliente cliente = BuscarCliente(numeroCliente);

            //4.- Si el cliente existe hacer lo siguiente
            //4.1 Si existe
            //4.1.1- Pedir al cliente el total del pedido
            // Console.Write("Introduce el total del pedido");
            // entrada = Console.Read();
            decimal totalPedido = 1200; //decimal.Parse(entrada);

            //4.1.2- Validar si el cliente es solvente contra el total del pedido
            if (cliente.Saldo <= totalPedido)
            {
                //	Si no es solvente se rechaza el pedido
                Console.WriteLine("Tu pedido fue rechazado");
            }
            else
            {
                //	Si es solvente se acepta el pedido
                Console.WriteLine("Tu pedido fue aceptado");
            }
            //4.2 Si no existe
            //4.2.1 Mandar mensaje de que no existe
            Console.WriteLine("Numero de Cliente inexistente");

            //6.- Fin  
        }
        //Busca y Regresa un Cliente
        static Cliente BuscarCliente(int numeroCliente)
        {
            //1.- Inicio
            //2.- Recibir el parametro de numero cliente
            //3.- Crear y obtener el banco de datos   -> Esto manda a llamar un subAlgoritmo 3
            List<Cliente> bancoDeDatos = CreaBancoDatos();
            //4.- Buscar dentro de banco de datos el numero de cliente
            //5.- Repertir hasta encontrar el cliente con el numero cliente que se recibio por parametro
            foreach (Cliente cliente in bancoDeDatos)
            {
                //5.1 Valida si existe el numero de cliente en banco de datos
                if (cliente.NumeroCliente == numeroCliente)
                {
                    //5.1.1 Si existe se regresa el cliente
                    return cliente;
                }

            }

            //6.- El cliente no existio regresamos nada
            return null;
            //7.- Fin
        }

        //Crea y Regresa un banco de Datos
        static List<Cliente> CreaBancoDatos()
        {
            //1.- Inicio
            //2.- Definir la entidad Cliente para el banco de datos
            //3.- Vamos a crear y a guardar 5 clientes en el banco de datos (Esto va ser de manera constante)
            List<Cliente> bancoDeDatos = new List<Cliente>();
            //----------------------------------------------------------------
            //3.1- Vamos a crear el cliente -> Asignar el numero, nombre y el saldo
            Cliente cliente = new Cliente();
            cliente.NumeroCliente = 1;
            cliente.Nombre = "Juanito Pérez";
            cliente.Saldo = 1000;
            //3.2- Vamos a guarda el cliente en el banco de datos
            bancoDeDatos.Add(cliente);
            //----------------------------------------------
            cliente = new Cliente();
            cliente.NumeroCliente = 2;
            cliente.Nombre = "Emiliano Hernandez";
            cliente.Saldo = 1100;
            //3.2- Vamos a guarda el cliente en el banco de datos
            bancoDeDatos.Add(cliente);
            //----------------------------------------------
            cliente = new Cliente();
            cliente.NumeroCliente = 3;
            cliente.Nombre = "Fernanda Gonzalez";
            cliente.Saldo = 2000;
            //3.2- Vamos a guarda el cliente en el banco de datos
            bancoDeDatos.Add(cliente);
            //----------------------------------------------
            cliente = new Cliente();
            cliente.NumeroCliente = 4;
            cliente.Nombre = "Luis Sanchez";
            cliente.Saldo = 500;
            //3.2- Vamos a guarda el cliente en el banco de datos
            bancoDeDatos.Add(cliente);
            //----------------------------------------------
            cliente = new Cliente();
            cliente.NumeroCliente = 5;
            cliente.Nombre = "Estefania gomez";
            cliente.Saldo = 0;
            //3.2- Vamos a guarda el cliente en el banco de datos
            bancoDeDatos.Add(cliente);
            //----------------------------------------------
            //4.- Regresamos el banco de datos
            return bancoDeDatos;
            //5.- Fin
        }
    }
    //2.- Definir la entidad Cliente para el banco de datos
    public class Cliente
    {
        public int NumeroCliente { get; set; }
        public string Nombre { get; set; }
        public decimal Saldo { get; set; }
    }

}

