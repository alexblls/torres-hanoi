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
            if (a.Top > b.Top)
            {
                a.push(b.pop());
            }
            if (b.Top > a.Top)
            {
                b.push(a.pop());
            }
            movimientos++;
        }

        public bool haySolucion(int n, Pila fin)
        {
            if (n == fin.Size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            if (n % 2 == 0)
            {
                while (!haySolucion(n,fin))
                {
                    mover_disco(ini, aux);
                    mover_disco(ini, fin);
                    mover_disco(aux, fin);
                }
            }
            else
            {
                while (!haySolucion(n, fin))
                {
                    mover_disco(ini, fin);
                    mover_disco(ini, aux);
                    mover_disco(aux, fin);
                }
            }
            return n; //o movimientos?
        }

    }
}
