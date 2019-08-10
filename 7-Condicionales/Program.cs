using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando Proyecto 7 - Condicionales");

            int edad = 16;

            int cantidadDePersonas = 2;

            if (edad >=18)
            {
                Console.WriteLine("Jose posee mas de 18 años de edad. Puede ingresar");
            }
            else
            {
                if (cantidadDePersonas >= 2)
                {
                    Console.WriteLine("Jose no posee mas de 18 de años de edad, pero, esta acompañado.");
                }
                else
                {
                    Console.WriteLine("Jose no posee mas de 18 de años de edad, no puede ingresar.");
                }
                
            }

            Console.ReadLine();
        }
    }
}
