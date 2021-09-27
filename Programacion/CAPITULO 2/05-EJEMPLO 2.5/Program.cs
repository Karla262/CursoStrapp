using System;

namespace _05_EJEMPLO_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.- Inicio
            //2.- Obtener el numero 
            Console.Write("Introduce el Número:");
            string entrada = Console.ReadLine();
            int numero = int.Parse(entrada);

            //3.- Repetir 2 hasta numero - 1
            for (int i = 2; i <= numero - 1; i++)
            {
                Console.WriteLine("{0} / {1} = {2}", numero, i, (numero / (decimal)i));
                //3.1 resto = N % iteracion
                int resto = numero % i;

                //3.2 Validar el resto
                if (resto == 0)
                {
                    //3.2.1 Si el resto es 0, NO ES UN NUMERO PRIMO
                    //3.2.1.1 Imprimir que N no es numero primo y salir
                    Console.WriteLine("El {0} no es primo", numero);
                    return;
                }





            }
            //3.2.2 En caso contrario (el resto es diferente a cero) es numero primo
            // 4.- Imprimir que numero es primo
            Console.WriteLine("El {0} es PRIMO", numero);

        }
    }
} //4.- Fin
