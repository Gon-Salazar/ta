using System;

namespace prestamo_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //recopilar informacion
            
            Console.WriteLine("fecha");
                 var currentDate = DateTime.Now ;
            Console.WriteLine($"{currentDate:d} at {currentDate:t}!");
            Console.ReadKey (true);

            Console.WriteLine("ingrese el monto solicitado");
            double Prestamo = double.Parse(Console.ReadLine());


            Console.WriteLine("ingrese el porcentaje de interes ");
            double interes = double.Parse(Console.ReadLine());


            Console.WriteLine("ingrese plazo en meses a pagar");
            int Tiempo = int.Parse(Console.ReadLine());

            //aqui hago los calculos
            interes = (Prestamo * interes) / 100;

            double PrestamoTotal = Prestamo + interes;

            double Cuotas = PrestamoTotal / Tiempo;
            //ahora muestro lo pedido en pantalla

            Console.WriteLine("el monto del crédito es de: " + PrestamoTotal);
            Console.WriteLine("la tasa a pagar es de: " + interes);
            Console.WriteLine("el tiempo a pagar es de: " + Tiempo);
            Console.WriteLine("la cuota mensual es de: " + Cuotas);
        }
    }
}