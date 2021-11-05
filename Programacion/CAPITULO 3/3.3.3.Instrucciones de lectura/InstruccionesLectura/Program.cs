using System;

namespace InstruccionesLectura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el valor de numeros:");
            string entrada = Console.ReadLine();
            int numeros = int.Parse(entrada);

            Console.WriteLine("Introduce el valor de Horas:");
            entrada = Console.ReadLine();
            int horas = int.Parse(entrada);

            Console.WriteLine("Introduce el valor de Tasas:");
            entrada = Console.ReadLine();
            int tasas = int.Parse(entrada);

            Console.WriteLine("Los valores son: " + numeros + ", " + horas+", " + tasas);

        }
    }
}
