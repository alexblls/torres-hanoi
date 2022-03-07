using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos discos quieres?");
            int nDiscos = 0;
            nDiscos = int.Parse(Console.ReadLine());

            Pila INI = new Pila(nDiscos)
            {
                Size = nDiscos
            };
            Pila FIN = new Pila();
            Pila AUX = new Pila();

            Console.WriteLine(nDiscos);
                                         
            // Keep the console window open in debug mode.
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();
        }
    }
}
