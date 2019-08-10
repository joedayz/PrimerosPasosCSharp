using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculoImpuestos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando proyecto 10 - Calcula impuesto");

            double valorInvertido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvertido = valorInvertido + valorInvertido * 0.0036;
                Console.WriteLine("El mes  " + contadorMes + ", Ud. tendrá S/. " + valorInvertido);

                contadorMes = contadorMes + 1;

            }
            Console.ReadLine();
        }
    }
}
