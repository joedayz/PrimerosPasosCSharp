using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Alcance
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando proyecto 9 - Alcance");

            int edadJose = 18;
            bool acompanhado = true;
            string mensajeAdicional;

            if (acompanhado == true)
            {
                mensajeAdicional = "Joe esta acompanhado!";
                Console.WriteLine(mensajeAdicional);
            }
            else
            {
                mensajeAdicional = "Joe NO esta acompanhado";
            }

            if (edadJose >= 18 && acompanhado == true)
            {
                Console.WriteLine("Puede entrar.");
                Console.WriteLine(mensajeAdicional);
            }
            else
            {
                Console.WriteLine("No puede entrar");
            }
            Console.ReadLine();
        }
    }
}
