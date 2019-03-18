using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericoslista
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int x ;
            listaEnlazada<int> l = new listaEnlazada<int>();
            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Mostrar");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("introduzca un elemento");
                        x =int.Parse( Console.ReadLine());
                        l.Insertar(Convert.ToString( x));
                        break;
                    case 2:
                        Console.WriteLine("que elemnto quiere eliminar");
                        x =int.Parse( Console.ReadLine());
                        l.Eliminar(Convert.ToString( x));
                        Console.ReadKey();
                        break;
                    case 3:
                        l.Mostrar();
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
