using System;

namespace Ejemplo2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Pagabruta=0;
		double Impuestos=0;
		double Pagoneto=0;
		Console.WriteLine("Ingrese las horas trabajadas");
		double HorasTrabajadas;
      	HorasTrabajadas=Convert.ToDouble(Console.ReadLine());
      	Console.WriteLine("Ingrese La tarifa Horaria");
		double TarifaHoraria;
		TarifaHoraria=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Ingrese la tasa de impuestos");
		double TasaImpuestos;
		TasaImpuestos=Convert.ToDouble(Console.ReadLine());
		
		Pagabruta = HorasTrabajadas * TarifaHoraria;
		Impuestos= ((Pagabruta * TasaImpuestos)/100);
		Pagoneto=Pagabruta -Impuestos;
		
		Console.WriteLine("Su pago Bruto es de: "+ Pagabruta);
		Console.WriteLine("Sus Impuestos a pagar son: "+Impuestos);
		Console.WriteLine("Su pago neto es de: "+ Pagoneto);
        }
    }
}