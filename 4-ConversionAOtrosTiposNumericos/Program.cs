using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversionAOtrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            double sueldo;
            sueldo = 1200.50;

            // int variable de 32 bits
            int salarioEnEntero;
            salarioEnEntero = (int) sueldo;

            Console.WriteLine("Salario en entero = " + salarioEnEntero);

            //long variable de 64 bits
            long edad;
            edad = 130000000000000;
            Console.WriteLine("Edad en long = " + edad);


            //short variable de 16 bits
            short cantidadDeProductos;
            cantidadDeProductos = 15000;
            Console.WriteLine("Cantidad de Productos en short = " + cantidadDeProductos);

            //float
            float altura = 1.80f;

            Console.WriteLine("Altura en float = " + altura);

            Console.ReadLine();
        }
    }
}
