using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegados_tarea
{
    delegate double Aritmetica(double x, double y);
    public class CSharpApp
    {
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
                        Console.WriteLine(DoOperacion(Suma, a, b));
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine(DoOperacion(Resta, a, b));
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine(DoOperacion(Multiplicacion, a, b));
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine(DoOperacion(Division, a, b));
                        Console.ReadKey();
                        break;
                    case 5:
                        opcion =5;
                        break;
                }
            }
            Console.ReadKey();
        }
        static double DoOperacion(Aritmetica op, double x, double y)
        {
            return (op(x, y));
        }
        static double Multiplicacion(double x, double y)
        {
            return x * y;
        }
        static double Division(double x, double y)
        {
            return x / y;
        }
        static double Suma(double x, double y)
        {
            return x + y;
        }
        static double Resta(double x, double y)
        {
            return x - y;
        }
    }
}
