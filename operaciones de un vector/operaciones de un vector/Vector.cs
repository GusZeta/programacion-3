using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaciones_de_un_vector
{
    class Vector
    {
        int[] x;
        int[] y;
        int n=int.Parse(Console.ReadLine());
        public static Vector Instancia;
        public constructor(int[] a, int[]b)
        {
            int n;
            n =int.Parse(Console.ReadLine());
            a =new int [n];
            b = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                n = int.Parse(Console.ReadLine());
                a[i] = n;
            }
            for (int i = 0; i < b.Length; i++)
            {
                n = int.Parse(Console.ReadLine());
                b[i] = n;
            }
            x = a;
            y = b;
        }
        public int Sumar()
        {
           return x[n] + y[n];
        }
        public int Resta()
        {
            return x[n] - y[n];
        }
        public int Multiplicar()
        {
            return x[n] * y[n];
        }
    }
}
