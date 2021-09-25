using System;

namespace _01_PROBLEMA_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int costoInicial = 20000;
            int costoRecuperacion = 2000;
            int anio = 2005;
            int numeroAnios = 6;
            decimal depreciacionAnual = (costoInicial - costoRecuperacion) / numeroAnios;
            decimal depreciacionAcumulada = 0;
            decimal valorAnual = costoInicial;
            int contador = 1;
            Console.WriteLine("Año          Depreciación        Depreciación Acumulada      ValorAnual");

            while (contador <= numeroAnios)
            {
                anio = anio + 1;
                depreciacionAcumulada = depreciacionAcumulada + depreciacionAnual;
                Console.WriteLine("{0}  ({1})        {2}        {3}     {4}", contador, anio, depreciacionAnual, depreciacionAcumulada, valorAnual);
                contador = contador + 1;
            }
        }
    }
}
