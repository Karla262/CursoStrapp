using System;

namespace _03_EJEMPLO_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.- Inicio 
            //1.1.- Declara e inicializar la variable totalSuma = 0
            int totalSuma = 0;

            //2.- repetir del 1 al 100
            for (int i = 1; i <= 100; i++)
            {
                //2.1 Imprimir la iteracion
                Console.WriteLine("Iteración: {0}", i);
                //2.2 totalSuma = totalSuma + iteracion
                totalSuma = totalSuma + i;
                Console.WriteLine("Total de suma actual:", totalSuma);
                //2.3 Fin de repetir 
                Console.WriteLine("------------------");
            }
            //3.- Fin
        }
    }
}
