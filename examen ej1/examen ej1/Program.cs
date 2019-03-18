using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean salir = false;
            coladocente<int> p = new coladocente<int>();
            coladocente<string> po = new coladocente<string>();
            int opcion = 0;
            
            int edad ;
            string nombre, sexo, carrera;
            while (salir != true)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Elegir una opcion");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Insertar Nombre");
                        nombre = Console.ReadLine();
                        po.insertarnombre(nombre);
                        Console.WriteLine("Insertar Edad");
                        edad = int.Parse(Console.ReadLine());
                        p.insertaredad(edad);
                        Console.WriteLine("Insertar Sexo");
                        sexo = Console.ReadLine();
                        po.insertarsexo(sexo);
                        Console.WriteLine("Insertar Carrera");
                        carrera = Console.ReadLine();
                        po.insertarcarrera(carrera);
                        break;
                    case 2:
                        
                        nombre = po.Eliminarnombre();
                        Console.WriteLine("Eliminado Nombre " + nombre);
                        edad = p.Eliminaredad();
                        Console.WriteLine("Eliminado edad " + edad);
                        sexo = po.Eliminarsexo();
                        Console.WriteLine("Eliminado sexo " + sexo);
                        carrera = po.Eliminarcarrera();
                        Console.WriteLine("Eliminado carrera " + carrera);
                        Console.ReadKey();
                        break;
                    case 3:
                        po.mostrar();
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
