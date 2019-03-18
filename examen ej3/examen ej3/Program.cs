using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_ej3
{
    public class multiplo
    {
        public delegate void Delegado(double n);
        public event Delegado CuandoRecibaMultiplocinco;
        public double Sumar(double x)
        {
            double iSuma = 0;

            if ((iSuma % 5 == 0) && (CuandoRecibaMultiplocinco != null))
            { CuandoRecibaMultiplocinco(iSuma); }
            Console.WriteLine("Multiplo de 5");
            return iSuma;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z,suma,prom;
            multiplo m = new multiplo();
            Console.WriteLine("Introduzca el valor de x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el valor de y");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el valor de z");
            z = double.Parse(Console.ReadLine());
            suma = x + y + z;
            prom = suma / 3;
            if (suma % 5 == 0)
            {
                m.Sumar(suma);
            }
            else
            {
                Console.WriteLine("" + prom);
            }
            Console.ReadKey();
        }
        
    }
}
