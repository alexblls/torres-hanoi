using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        int movimientos = 0;
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            if (!haySolucion(Pila.discosTotal,b))
            {
                if (a.isEmpty())
                {
                    a.push(b.pop());
                }
                else if (b.isEmpty())
                {
                    b.push(a.pop());
                }
                else if (a.Elementos.First().Valor < b.Elementos.First().Valor)
                {
                    b.push(a.pop());
                }
                else
                {
                    a.push(b.pop());
                }
                
                movimientos++;
            }
            
        }

        public bool haySolucion(int n, Pila fin)
        {
            if (n == fin.Elementos.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void imprimirTorres(Pila ini, Pila fin, Pila aux)
        {
            Console.Write(" ( ");
            for (int i = 0; i < ini.Elementos.Count; i++)
            {
                Console.Write(ini.Elementos[i].Valor);
            }
            Console.Write(" ) , ( ");
            for (int i = 0; i < aux.Elementos.Count; i++)
            {
                Console.Write(aux.Elementos[i].Valor);
            }
            Console.Write(" ) , ( ");
            for (int i = 0; i < fin.Elementos.Count; i++)
            {
                Console.Write(fin.Elementos[i].Valor);
            }
            Console.Write(" ) ");
            if (movimientos != 0)
            {
                Console.Write(" => Movimientos: ");
                Console.Write(movimientos);
            }
            Console.WriteLine();
        }
        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            imprimirTorres(ini, fin, aux);
            if (n % 2 == 0)
            {
                while (!haySolucion(n, fin))
                {
                    mover_disco(ini, aux);
                    imprimirTorres(ini, fin, aux);
                    mover_disco(ini, fin);
                    imprimirTorres(ini, fin, aux);
                    mover_disco(aux, fin);
                    imprimirTorres(ini, fin, aux);
                }
            }
            else
            {
                while (!haySolucion(n, fin))
                {
                    mover_disco(ini, fin);
                    imprimirTorres(ini, fin, aux);
                    mover_disco(ini, aux);
                    imprimirTorres(ini, fin, aux);
                    mover_disco(aux, fin);
                    imprimirTorres(ini, fin, aux);
                }
            }
            return n;
        }
    }
}
