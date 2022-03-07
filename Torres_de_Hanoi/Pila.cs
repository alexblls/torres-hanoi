using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; }
        /* TODO: Elegir tipo de Top
        public int Top { get; set; }
        public String Top { get; set; }        
        */

        public int Top { get; set; }
        /* TODO: Elegir tipo de Elementos
        public Disco[] Elementos { get; set; }
        public List<Disco> Elementos { get; set; }
        */

        public List<Disco> Elementos { get; set; }

        /* TODO: Implementar métodos */
        public Pila()
        {
            Size = 0;
            Top = 0;
            Elementos = new List<Disco>();//revisar
        }

        public void push(Disco d)
        {
            Elementos.Add(d);
        }

        public Disco pop()
        {
            if (!isEmpty())
            {
                //Elimina el elemento de la lista en la primera posicion
                Disco discoArriba = Elementos.Last();
                Elementos.RemoveAt(Elementos.Count - 1);
                return discoArriba;
            }
            else
            {
                return null;
            }
        }

        public bool isEmpty()
        {
            if (Size == 0)
                return true;
            else
                return false;
        }
    }
}
