using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_CalculoInteres_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando el proyecto 12");

            double valorInvertido = 1000;
            double fatorRendimiento = 1.0036;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvertido *= fatorRendimiento;
                }
                fatorRendimiento += 0.0010;
            }

            Console.WriteLine("Al termino de la inversión, Ud. tendrá S/." + valorInvertido);
            Console.ReadLine();
        }
    }
}
