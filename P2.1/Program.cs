using System;

namespace _01_Problema_2._1
{
    class Program 
    {
        static void Main(string[] args)
        {
           int CInicial=20000;
           int CRecuperacion=2000;
           int Anio=2005;
           int NumeroAnios=6;
           decimal depreciacionAnual=(CInicial-CRecuperacion)/NumeroAnios;
           decimal depreciacionacumulada=0;
           decimal valoranual=costoinicial;
           int contador=1;
           Console.WriteLine("Año           Depreciacion            Depreciacion Acomulada       ValorAnual");

            while (contador <= NumeroAnios)
            {
                Anio=Anio+1;
                depreciacionacumulada = depreciacionacumulada + depreciacioAnual;
                valoranual = valoranual - depreciacioAnual;
                Console.WriteLine("{0} ({1})            {2}               {3}                         {4}",contador, Anio, depreciacioAnual, depreciacionacomulada, valoranual);
                contador = contador +1;
                
            }
        }
    }
}
