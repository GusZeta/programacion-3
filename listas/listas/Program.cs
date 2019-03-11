using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            string x = "";
            List < string > l= new List<string>();
            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("1: Insertar");
                Console.WriteLine("2: Eliminar");
                Console.WriteLine("3: Mostrar");
                Console.WriteLine("4: Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduzca un elemento");
                        x = Console.ReadLine();
                        l.Add(x);
                        break;
                    case 2:
                        Console.WriteLine("Eliminar un elemento");
                        x = Console.ReadLine();
                        l.Remove(x);
                        break;
                    case 3:
                        foreach (string lista in l)
                        {
                            Console.WriteLine(lista);
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
