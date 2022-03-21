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

            for (int i = 1; i <= nDiscos; i++)
            {
                Disco d = new Disco();
                d.Valor = i;
                INI.Elementos.Add(d);
            }

            Hanoi hanoi = new Hanoi();

            hanoi.iterativo(nDiscos, INI, FIN, AUX);
            Console.WriteLine(nDiscos);
        }
    }
}
