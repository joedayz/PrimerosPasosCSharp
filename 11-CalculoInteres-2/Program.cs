using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CalculoInteres_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando el proyecto 11");

            double valorInvertido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvertido *= 1.0036;
                Console.WriteLine(
                    "El mes " + contadorMes +
                    " , Ud. tendrá S/." + valorInvertido);
            }
            Console.ReadLine();
        }
    }
}
