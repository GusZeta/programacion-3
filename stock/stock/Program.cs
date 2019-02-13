using System;

namespace stock
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventario inv = new Inventario();
            inv.stockminimo += jeje;
            int n;
            Boolean salir = false;
            while (salir == false)
            {

                Console.Clear();
                Console.WriteLine("1. Incrementar");
                Console.WriteLine("2. Disminuir");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Elegir una opcion");
                int ope = int.Parse(Console.ReadLine());
                switch (ope)
                {
                    case 1:
                        Console.WriteLine("Introduzca n");
                        n = int.Parse(Console.ReadLine());
                        inv.incrementarstock(n);
                        break;
                    case 2:
                        Console.WriteLine("Introduzca n");
                        n = int.Parse(Console.ReadLine());
                        inv.disminuirstock(n);
                        break;
                    case 3:
                        inv.mostrarstock();
                        Console.ReadKey();
                        break;
                    case 4:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Accion no valida");
                        break;
                }
            }
            Console.ReadKey();
        }
        static void jeje(int n)
        {
            Console.WriteLine("El stock esta en su minimo {0}", n);
            Console.ReadKey();
        }

    }
    
}
