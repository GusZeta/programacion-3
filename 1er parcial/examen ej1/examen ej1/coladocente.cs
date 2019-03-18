using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_ej1
{
    class coladocente<T>
    {
        public const int Maximo = 10;
        private T[] arreglo = new T[Maximo];
        private int final = 0;
        private int frente = 0;
        public void insertarnombre(T valor)
        {
            if (!Llena())
            {
                final = (final + 1) % Maximo;
                arreglo[final] = valor;
            }
            else
                Console.WriteLine("La cola esta llena");
        }
        public void insertaredad(T valor)
        {
            if (!Llena())
            {
                final = (final + 1) % Maximo;
                arreglo[final] = valor;
            }
            else
                Console.WriteLine("La cola esta llena");
        }
        public void insertarsexo(T valor)
        {
            if (!Llena())
            {
                final = (final + 1) % Maximo;
                arreglo[final] = valor;
            }
            else
                Console.WriteLine("La cola esta llena");
        }
        public void insertarcarrera(T valor)
        {
            if (!Llena())
            {
                final = (final + 1) % Maximo;
                arreglo[final] = valor;
            }
            else
                Console.WriteLine("La cola esta llena");
        }
        public T Eliminarnombre()
        {
            if (!Vacia())
            {
                T x = arreglo[frente];
                frente = (frente + 1) % Maximo;
                return x;
            }
            else
            {
                Console.WriteLine("La  cola esta vacia");
                return arreglo[frente];
            }
        }
        public T Eliminaredad()
        {
            if (!Vacia())
            {
                T x = arreglo[frente];
                frente = (frente + 1) % Maximo;
                return x;
            }
            else
            {
                Console.WriteLine("La  cola esta vacia");
                return arreglo[frente];
            }
        }
        public T Eliminarsexo()
        {
            if (!Vacia())
            {
                T x = arreglo[frente];
                frente = (frente + 1) % Maximo;
                return x;
            }
            else
            {
                Console.WriteLine("La  cola esta vacia");
                return arreglo[frente];
            }
        }
        public T Eliminarcarrera()
        {
            if (!Vacia())
            {
                T x = arreglo[frente];
                frente = (frente + 1) % Maximo;
                return x;
            }
            else
            {
                Console.WriteLine("La  cola esta vacia");
                return arreglo[frente];
            }
        }
        public void mostrar()
        {
            int aux = frente;
            while (aux != final)
            {
                Console.Write("{0}", arreglo[aux] + " ");
                aux = (aux + 1) % Maximo;
            }
        }
        private Boolean Llena()
        {
            return ((final + 1) % Maximo) == frente;
        }
        private Boolean Vacia()
        {
            return frente == final;
        }
        
    }
}
