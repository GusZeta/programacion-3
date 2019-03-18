using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilaalumno
{
    class pilaalumno<alumno>
    {
        public const int maximo = 15;
        private alumno[] vector = new alumno[maximo];
        
        private int  tope = -1;

        public void insertarNombre(alumno valor)
        {
            if (!llena())
            {
                tope++;
                vector[tope] = valor;
            }
            else
            {
                Console.WriteLine("La pila esta llena");
            }
        }
        public void insertarEdad(alumno valor)
        {
            if (!llena())
            {
                tope++;
                vector[tope] = valor;
            }
            else
                Console.WriteLine("La pila esta llena");
        }
        public void insertarSexo(alumno valor)
        {
            if (!llena())
            {
                tope++;
                vector[tope] = valor;
            }
            else
            {
                Console.WriteLine("La pila esta llena");
            }
        }
        public void insertarCarrera(alumno valor)
        {
            if (!llena())
            {
                tope++;
                vector[tope] = valor;
            }
            else
            {
                Console.WriteLine("La pila esta llena");
            }
        }
        public alumno eliminarEdad()
        {
            if (!vacia())
            {
                tope--;
                return vector[tope + 1];
            }
            else
            {
                Console.WriteLine("La pila esta vacia");
                return vector[tope];
            }
        }
        public alumno eliminarNombre()
        {
            if (!vacia())
            {
                tope--;
                return vector[tope + 1];
            }
            else
            {
                Console.WriteLine("La pila esta vacia");
                return vector[tope];
            }
        }
        public void mostrar()
        {
            for (int i = 0; i <= tope; i++)
            {
                Console.WriteLine("{0}", vector[i]);

            }


        }
        private Boolean vacia()
        {
            return tope == -1;
        }
        private Boolean llena()
        {
            return tope == maximo;

        }
    }
}
