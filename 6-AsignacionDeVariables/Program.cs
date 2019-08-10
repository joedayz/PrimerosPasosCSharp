using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AsignacionDeVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6 - Asignación de Variables");

            int edad = 32;
            int edadJose = edad;

            edad = 20;

            Console.WriteLine(edad);
            Console.WriteLine(edadJose);

            Console.ReadLine();
        }
    }
}
