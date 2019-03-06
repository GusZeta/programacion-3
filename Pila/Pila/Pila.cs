using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    class Pila<T>
    { 
        public const int maximo = 10;
        private T[] arreglo = new T[maximo];
        private int tope = -1;
        public void push(T valor)
        {
            if (!Llena())
            {
                tope++;
                arreglo[tope] = valor;
            }
            else
            {
                Console.WriteLine("La pila esta llena");
            }
        }

        private Boolean Llena()
        {
            return tope == maximo;
        }

        public T pop()
        {
            if (!Vacia())
            {
                tope--;
                return arreglo[tope + 1];
            }
            else
            {
                Console.WriteLine("La pila esta vacia");
                return arreglo[tope + 1];
            }
        }

        private Boolean Vacia()
        {
            return tope == -1;
        }
        public void mostrar()
        {
            for (int i = 0; i <= tope; i++)
                Console.Write(arreglo[i] + "");
        }

    }
}
