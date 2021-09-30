using System;

namespace _11_EJEMPLO_2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dados tres números, determinar si la suma de cualquier pareja de 
            //             ellos es igual al tercer número.
            //1.Inicio Leer los tres valores: A, B y C. 
            int flag = 0;

            Console.Write("Numero a:");
            string entrada = Console.ReadLine();
            int a = int.Parse(entrada);

            Console.Write("Numero b:");
            string entradaa = Console.ReadLine();
            int b = int.Parse(entradaa);

            Console.Write("Numero c:");
            string entradaaa = Console.ReadLine();
            int c = int.Parse(entradaaa);
            //2.-C=A+B si no C=A+B si no C=A+B 
            if((a+b)==c){
                 Console.WriteLine("Iguales");
                 flag = 1;
                }
                if((a + c) == b ){
                     Console.WriteLine("Iguales");
                     flag = 1;
                }
                    if(( b + c ) == a ){
                         Console.WriteLine("Iguales");
                         flag = 1;
                }
                         if(flag == 0){
                         Console.WriteLine("Distintas");
                         }
        }
    }
}
