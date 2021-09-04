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
           int auxiliar=1;
           Console.WriteLine("Año           Depreciacion            Depreciacion Acomulada       ValorAnual");

            while (auxiliar <= NumeroAnios)
            {
                Anio=Anio+1;
                depreciacionacumulada = depreciacionacumulada + depreciacioAnual;
                valoranual = valoranual - depreciacioAnual;
                Console.WriteLine("{0} ({1})            {2}               {3}                         {4}",auxiliar, Anio, depreciacioAnual, depreciacionacumulada, valoranual);
                auxiliar = auxiliar +1;
                
            }
        }
    }
}
