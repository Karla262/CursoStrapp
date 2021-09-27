using System;

namespace _08_EJEMPLO_2._8
{
    class Program
    {
        static void Main(string[] args)
        {
    //Suma de los números pares comprendidos entre 2 y 100. Con Validación
            //1.- Inicio
            //2.- Declarar e inicializar la variable suma = 0
            int suma = 0;

            //3.- Repetir del 1 al 100
            for(int numero = 1; numero <= 100; numero++){
                //3.1 Calcular el residuo de numero entre 2 -> Esto siempre me va dar 1 o 0 Es el comportamiento de division de 2
                int residuo = numero % 2;
                //3.2 Validar si el residuo es 0 (Si es 0 es numero par)
                if(residuo == 0){
                    //3.2.1 Sumar el numero par a la variable suma.
                    suma = suma +numero;
                }
            }
            //4.- Mostrar la suma de los numeros pares
            Console.WriteLine("La suma de los números pares del 1 al 100 es {0}", suma);
            //5.- Fin
        }
    }
}
