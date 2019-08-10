using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ForEncadenado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proyecto 13");

            // *
            // **
            // ***
            // ****
            // *****
            // ******
            // *******
            // ********
            // *********
            // **********
            // Escribiendo asteriscos con BREAK
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                        break;
                }
                Console.WriteLine();
            }

            // Una forma diferente de hacer el diseño de asteriscos
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                    Console.Write("*");
                
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
