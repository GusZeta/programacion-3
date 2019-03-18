using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericoslista
{
 class Nodo<T>
    {
        public string info;
        public Nodo<T> Siguiente;
        public Nodo(string valor)
        {
            info = valor;
            Siguiente = null;
        }
    }

    class listaEnlazada<T>
    {
        public Nodo<T> Actual;
        public void Insertar(string valor)
        {
            Nodo<T> nuevo = new Nodo<T>(valor);

            if (Actual == null)
            { Actual = nuevo; }
            else
            {
                Nodo<T> aux = Actual;
                while (aux.Siguiente != null)
                {
                    aux = aux.Siguiente;
                }

                aux.Siguiente = nuevo;
            }
        }
        public void Eliminar(string valor)
        {
            if (Actual != null)
            {
                Nodo<T> aux = Actual;
                Nodo<T> ant = null;
                while (aux.Siguiente != null && aux.info != valor)
                {
                    ant = aux;
                    aux = aux.Siguiente;
                }
                if (aux.info == valor)
                {
                    if (ant == null)
                        Actual = aux.Siguiente;
                    else
                        ant.Siguiente = aux.Siguiente;
                }
                else
                    Console.WriteLine("No se encontro el valor");


            }
        }
        public void Mostrar()
        {
            if (Actual != null)
            {
                Nodo<T> aux = Actual;
                while (aux != null)
                {
                    Console.WriteLine(aux.info);
                    aux = aux.Siguiente;

                }
            }
        }

    }
   
}
