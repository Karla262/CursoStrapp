using System;

namespace _07_EJEMPLO_2._7
{
    class Program
    {
        static void Main(string[] args)
        {
                    //1.- Inicio
                   // 2.- Declarar suma = 0
                   int suma = 0;
                   // 3.- Declarar contador = 0
                   int contador = 0;
                   // 4.- Declarar numero;
                   int numero;
                  //  5.- hacer esto
                  do{

                       // 5.1 Obtener de la terminal un numero y guardar en la variable numero
                        Console.Write("Introduce un número:");
                        string entrada = Console.ReadLine();
                        numero = int.Parse(entrada);

                       // 5.2 Validar que numero no sea 0 (Numero se difente de 0 numero != 0)
                       if(numero != 0){
                             // 5.2.1 Agrega, Acumula o suma el numero a la variable suma
                             suma = suma + numero;
                           // 5.2.2 Incremente contador en 1
                           contador++;  //contaodr = comtador + 1 Forma Explicita
                       }
                   // 6.- mientras numero no sea igual 0
                  }while (numero != 0);
                  
                   // 7.- calcular la media y guardarla en la variable media suma / contador
                  decimal media =  suma / contador;
                   // 8.- Mostrar la media 
                   Console.WriteLine("La Media es: {0}", media);
                   // 9.- Fin
        }
    }
}
