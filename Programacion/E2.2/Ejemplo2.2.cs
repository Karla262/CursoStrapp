using System;

namespace Ejemplo2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Contador=1;
        int suma=0;
        while(Contador <= 100)
        {
            suma=suma+Contador;
            Contador++;
        }
        Console.WriteLine(suma);
        }
    }
}
