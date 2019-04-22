using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pila
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean salir = false;
            Pila<int> p= new Pila<int>();
            Thread hilo = new Thread(new ThreadStart(calcular));
            hilo.Start();
            int opcion = 0;
            int x = 0;
            while (salir != true)
            {
                Console.Clear();
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Elegir una opcion");
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("");
                        x = int.Parse(Console.ReadLine());
                        p.push(x);
                        Console.ReadKey();
                        break;
                    case 2:
                        x = p.pop();
                        Console.WriteLine("El elemento eliminado es " + x);
                        Console.ReadKey();
                        break;
                    case 3:
                        p.mostrar();
                        Console.ReadKey();
                        break;
                    case 4:

                        break;
                }
                Console.ReadKey();
            }
            Console.ReadKey();
        }
        public static void calcular()
        {
            int sumatoria = 0;
            for (int i = 1; i <= 1000; i++)
            {
                sumatoria = i;


            }
            Console.WriteLine("La sumatoria es: " + sumatoria);
        }
    }
}
