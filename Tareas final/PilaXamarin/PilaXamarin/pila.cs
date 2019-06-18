using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace PilaXamarin
{
    class Pila<T>
    {
        public const int Maximo = 10;
        private T[] arreglo = new T[Maximo];
        private int tope = -1;
        public void push(T valor)
        {
            if (!LLena())
            {
                tope++;
                arreglo[tope] = valor;
            }
            else
                Console.WriteLine("La Pila esta llena");
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
                Console.WriteLine("La Pila esta vacia");
                return arreglo[tope + 1];
            }
        }
        public T[] mostrar()
        {
            T[] aux = new T[tope + 1];
            for (int i = 0; i < tope; i++)
                aux[i] = arreglo[i];
            return aux;

        }
        private Boolean Vacia()
        {
            return tope == -1;
        }
        private Boolean LLena()
        {
            return tope == Maximo;
        }
        
    }
}