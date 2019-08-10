using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionales_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("8 - Condicionales 2");

            int edad = 16;
            int cantidadDePersonas = 2;

            bool acompanhado = cantidadDePersonas >= 2;

            if (edad >= 18 && acompanhado == true)
            {
                Console.WriteLine("Puede entrar");
            }
            else
            {
                Console.WriteLine("No puede entrar");
            }

            Console.ReadLine();
        }
    }
}
