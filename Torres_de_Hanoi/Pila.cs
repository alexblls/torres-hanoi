using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public static int discosTotal;
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
            Elementos = new List<Disco>();
        }

        public Pila(int n)
        {

            Size = n;
            discosTotal = n;
            Top = 1;
            Elementos = new List<Disco>();

            for (int i = 1; i == n; i++)
            {
                Disco disco = new Disco();
                disco.Valor = i;
                Elementos.Add(disco);
            };
        }

        public override string ToString()
        {
            return base.ToString(); 
        }

        public void push(Disco d)
        {
            Elementos.Insert(0, d);
        }

        public Disco pop()
        {
            //Elimina el elemento de la lista en la primera posicion
            Disco discoArriba = Elementos.First();
            Elementos.RemoveAt(0);
            Size = Elementos.Count;
            if (Elementos.Count == 0)
            {
                Top = 0;
            }
            else
            {
                Top = Elementos.First().Valor;
            }
            return discoArriba;
      
        }

        public bool isEmpty()
        {
            if (Elementos.Count == 0)
                
                return true;
            else
                return false;
        }
    }
}
