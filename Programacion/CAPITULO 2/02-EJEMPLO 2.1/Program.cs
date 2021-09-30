using System;

namespace _02_EJEMPLO_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicio
            string entrada = string.Empty;

            //2 Obtener Horas Trabajadas
            Console.WriteLine("Introduce las horas trabajadas:");
            entrada = Console.ReadLine();
            int horasTrabajadas = int.Parse(entrada);

            //3 Obtener tarifaHoraria
            Console.WriteLine("Introduce la Tarifa Horaria:");
            entrada = Console.ReadLine();
            int tarifaHoraria = int.Parse(entrada);

            //4 Obtener TasaImpuesto
            Console.WriteLine("Introduce la Tasa de Impuesto:");
            entrada = Console.ReadLine();
            decimal tasaImpuesto = decimal.Parse(entrada);

            //5 Declarar variables PagoBruto, ImpuestoAPagar, PagoNeto
            int pagoBruto = 0;
            decimal impuestoAPagar = 0;
            decimal pagoNeto = 0;

            //6 Calcular pagoBruto = HorasTrabajadas * Tarifahoraria
            pagoBruto = horasTrabajadas * tarifaHoraria;

            //7 Calcular ImpuestoAPagar = PagoBruto * TasaImpuesto
            impuestoAPagar = pagoBruto * impuestoAPagar;

            //8 Calcular PagoNeto = pagoBruto - ImpuestoAPagar
            pagoNeto = pagoBruto - impuestoAPagar;

            //9 Imprimir el pago neto
            Console.WriteLine("El pago neto es:" + pagoNeto);

            //10 Fin







        }
    }
}
