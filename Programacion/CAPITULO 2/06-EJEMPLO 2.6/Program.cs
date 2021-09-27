using System;

namespace _06_EJEMPLO_2._6
{
    class Program
    {
        static void Main(string[] args)
        {
    // //Realizar la suma de todos los números pares entre 2 y 1.000.
    //             //1.- Inicio
    //             //2.- Declara e inicializar suma = 0
    //             int suma = 0;
    //            // 3.- Repetir de 2 en 1 hasta 1000
    //            for(int numero = 2; numero <= 1000; numero = numero + 2)
    //            {
    //                //3.1 sumar el numero de la iteracion a la variable suma 
    //                suma = suma + numero;
    //            }
    //            // 5.- Mostrar la suma de los numeros
    //            Console.WriteLine("La Suma de todos los numeros es {0}", suma);


            //1.-Inicio
            //2.- Declara e inicializar suma = 0
            int suma = 0;
            //3.- Declara e inicializar el numero 2 (Este es el que va ir incrementado de 2 en 2)
            int numero = 2;
            //4.- Repetir mientras  numero sea menor que 1000
            while(numero <= 1000)
            {
                 //4.1 Sumar el numero a la variable suma
                 suma = suma + numero;
                //4.2 Incrementa el numero en 2
                numero = numero + 2;
            }
                    
            //5.- Mostrar la suma de los numeros
            Console.WriteLine("La suma de los números es: {0}", suma);

               }
                        
               
        }
    }

