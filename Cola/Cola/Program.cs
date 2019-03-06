using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean salir = false;
            cola<int> p = new cola<int>();
            int opcion = 0;
            int x = 0;
            while (salir != true)
            {
                Console.Clear();
                Console.WriteLine("1. Incrementar");
                Console.WriteLine("2. Disminuir");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Elegir una opcion");
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("");
                        x = int.Parse(Console.ReadLine());
                        p.insertar(x);
                        Console.ReadKey();
                        break;
                    case 2:
                        x = p.Eliminar();
                        Console.WriteLine("El elemento eliminado es "+x);
                        Console.ReadKey();
                        break;
                    case 3:
                        p.mostrar();
                        Console.ReadKey();
                        break;
                    case 4:
                        salir = true;
                        break;
                }
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
