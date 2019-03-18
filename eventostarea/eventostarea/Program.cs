using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventostarea
{
    public class multiplo
    {
        public delegate void Delegado(int n); 
        public event Delegado CuandoRecibaMultiplotres; 
        public int Sumar(int x)
        {
            int iSuma = 0;
            
            if ((iSuma % 3 == 0) && (CuandoRecibaMultiplotres != null)) 
            { CuandoRecibaMultiplotres(iSuma); }
            return iSuma;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, n, re = 0;
            Console.WriteLine("Introduzca el limite");
            n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            multiplo m = new multiplo();
            m.CuandoRecibaMultiplotres += mult3;
            Console.WriteLine("Introduzca {0} valores", n);
            for(int i=0;i<n;i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
                suma = suma + vector[i];
                re = m.Sumar(vector[i]);
            }
            Console.WriteLine("Suma:" + suma);
            Console.ReadKey();
        }        
        static void mult3(int x)
        {
            double div = x / 3;
            Console.WriteLine("Division:" + div);
        }
    }
    
}
