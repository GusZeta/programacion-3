using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Preguntas
{
    class Program
    {
        public static void Tiempo()
        {
            
            Thread.Sleep(6000);
        }
        public static void Preguntas()
        {
            string y;
            int x = 0;
            Console.WriteLine("¿Cual es la capital de Bolivia?");
            y = Console.ReadLine();
            if (y == "Sucre")
            {
                x++;
            }
            Console.WriteLine("¿Cuantos departamentos tiene Bolivia?");
            y = Console.ReadLine();
            if (y == "7" || y == "siete")
            {
                x++;
            }
            Console.WriteLine("¿cuanto es (((2+3)*4)/10)*9?");
            y = Console.ReadLine();
            if (y == "18")
            {
                x++;
            }
            Console.WriteLine("¿Cual es la recompensa actual de Luffy?");
            y = Console.ReadLine();
            if (y == "1500000000")
            {
                x++;
            }
            Console.WriteLine("¿Cuantas estrellas tiene Estados Unidos?");
            y = Console.ReadLine();
            if (y == "50" || y == "cincuenta")
            {
                x++;
            }
            Console.WriteLine("(x+4)+(-5x-6)=-30 ¿x?");
            y = Console.ReadLine();
            if (y == "7")
            {
                x++;
            }
            Console.WriteLine("¿Cuantos años tiene FOX?");
            y = Console.ReadLine();
            if (y == "21")
            {
                x++;
            }
            Console.WriteLine("¿Año del primer grito libertario?");
            y = Console.ReadLine();
            if (y == "1809")
            {
                x++;
            }
            Console.WriteLine("¿Velocidad de un cuerpo que rrecorrio 5 Km en 5 minutos?");
            y = Console.ReadLine();
            if (y == "16,67")
            {
                x++;
            }
            Console.WriteLine("¿Cuanto es 2+2?");
            y = Console.ReadLine();
            if (y == "4")
            {
                x++;
            }
            Console.WriteLine("el puntaje es: " + x);
        }
        static void Main(string[] args)
        {
            Thread p = new Thread(new ThreadStart(Preguntas));
            Thread t = new Thread(new ThreadStart(Tiempo));
            p.Start();
            t.Start();
            t.Join();
            p.Abort();
            Console.ReadKey();
        }
    }
}
