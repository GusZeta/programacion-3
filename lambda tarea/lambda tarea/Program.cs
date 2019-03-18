using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_tarea
{
    class Program
    {
        delegate double Aritmetica(double a, double b);
        static void Main(string[] args)
        {
            int opcion = 0;
            double a, b;
            Console.WriteLine("Ingrear valor de a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrear valor de b");
            b = double.Parse(Console.ReadLine());
            while (opcion != 5)
            {
                Console.Clear();
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Salir");

                opcion = int.Parse(Console.ReadLine());
                
                switch (opcion)
                {
                    case 1:
                        Aritmetica del = (double x, double y) =>
                        { return x + y; };
                        Console.WriteLine(del(a, b));
                        Console.ReadKey();
                        break;
                    case 2:
                        del = (double x, double y) =>
                        { return x - y; };
                        Console.WriteLine(del(a, b));
                        Console.ReadKey();
                        break;
                    case 3:
                        del = (double x, double y) =>
                        { return x * y; };
                        Console.WriteLine(del(a, b));
                        Console.ReadKey();
                        break;
                    case 4:
                        del = (double x, double y) =>
                        { return x / y; };
                        Console.WriteLine(del(a, b));
                        Console.ReadKey();
                        break;
                    case 5:
                        opcion = 5;
                        break;
                }
            }
 
        }
    }
}
