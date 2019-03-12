using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese valor de n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("fibonacci(1)={0}", fibonacci2(1));
            Console.WriteLine("fibonacci(5)={0}", fibonacci2(5));
            Console.WriteLine("fibonacci(3)={0}", fibonacci2(3));
            Console.WriteLine("fibonacci(n)={0}", fibonacci2(n));
            Console.ReadKey();
        }

        private static int fibonacci2(int n)
        {

            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return fibonacci2(n - 1) + fibonacci2(n - 2);                              
            }
            
        }
    }
}
