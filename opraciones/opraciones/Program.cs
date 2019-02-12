using System;

namespace opraciones
{
    class Program
    {
        private static int n;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Operaciones o = new Operaciones();
            
            o.cuandoesmultiplodetres += sumatoria;
            Console.WriteLine("el factorial de {0} es {1}", n, o.factorial(n));
            Console.ReadKey();
        }
        static void sumatoria(int n)
        {
            int i, x=0;

            for (i = 1; i <= n; i++)
            {
                x = x + i;
                
            }
            Console.WriteLine("la sumatoria es: " + x);
            
        }
    }
    class Operaciones
    {
        public delegate void Delegado(int n);
        public event Delegado cuandoesmultiplodetres;
        public int factorial(int n)
        {
            
            int i, y=1;
            
            for (i = 1; i <= n; i++)
            {
                y = y * i;
            }
            if((y%3==0)&&(cuandoesmultiplodetres !=null))
            {
                cuandoesmultiplodetres(n);
            }
            return y;
        }
    }
   
}
