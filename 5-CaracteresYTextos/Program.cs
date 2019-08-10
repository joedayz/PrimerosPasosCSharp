using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresYTextos
{
    class Program
    {
        static void Main(string[] args)
        {
            char primeraLetra = 'a';
            Console.WriteLine("Primera Letra " + primeraLetra);

            primeraLetra = (char)65;
            Console.WriteLine("Segunda Letra " + primeraLetra);

            primeraLetra = (char)(primeraLetra + 1);
            Console.WriteLine("Tercera Letra " + primeraLetra);

            string titulo = "JoeDayz " + 2020;
            string cursosProgramacion = @"- .NET 
- Java
- Javascript";

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacion);

            Console.ReadLine();
        }
    }
}
