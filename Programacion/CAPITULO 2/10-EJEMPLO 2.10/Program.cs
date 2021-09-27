using System;

namespace _10_EJEMPLO_2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.- Inicio
            //2.- Definir el arreglo
            int[] arreglo = {5, 3, 0, 2, 4, 4, 0, 0, 2, 3, 6, 0, 2};

            //3.- Declar e inicializar el contador = 0
            int contador = 0;

            //4.- Repetir 0 hasta la longitud del arreglo(13)
            for(int i = 0; i < arreglo.Length; i++){
                //4.1. Obtener el numero en el arreglo en la posicion o iteracion actual
                int numero = arreglo[i];

                //4.2. Validar el numero si es igual a 0
                if(numero == 0){
                          // 4.2.1 Incrementar el contador
                          contador++;
                }
                     
            }
               
            //5.- Mostrar el numero de 0 encontrados
            Console.WriteLine("Se encontraron {0} ceros", contador);
           // 6.- Fin
        }
    }
}
