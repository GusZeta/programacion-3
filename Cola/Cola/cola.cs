using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola
{
    class cola<T>
    {
        public const int Maximo = 10;
        private T[] arreglo = new T[Maximo];
        private int final = 0;
        private int frente = 0;
        public void insertar(T valor)
        {
            if (!Llena())
            {
                final = (final + 1) % Maximo;
                arreglo[final] = valor;
            }
            else
                Console.WriteLine("La cola esta llena");
        }
        public T Eliminar()
        {
            if (!Vacia())
            {
                T x=arreglo[frente];
                frente = (frente + 1) % Maximo;
                return x;
            }
            else
            {
                Console.WriteLine("La  cola esta vacia");
                return arreglo[frente];
            }
        }
        private Boolean Llena()
        {
            return ((final+1) % Maximo)==frente;
        }
        private Boolean Vacia()
        {
            return frente == final;
        }
        public void mostrar()
        {
            int aux = frente;
            while (aux != final)
            {
                Console.Write(arreglo[aux] + "");
                aux = (aux + 1) % Maximo;
            }
                


        }
    }
}
