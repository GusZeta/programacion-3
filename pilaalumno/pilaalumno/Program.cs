using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilaalumno
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean salir = false;
            pilaalumno<string> p = new pilaalumno<string>();
            pilaalumno<int> pi = new pilaalumno<int>();
            int opcion = 0;
            int edad = 0;
            string nombre, sexo, carrera;
            while (salir != true)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Insertar Nombre");
                        nombre = Console.ReadLine();
                        p.insertarNombre(nombre);
                        Console.WriteLine("Insertar Edad");
                        edad = int.Parse(Console.ReadLine());
                        pi.insertarEdad(edad);
                        Console.WriteLine("Insertar Sexo");
                        sexo = Console.ReadLine();
                        p.insertarSexo(sexo);
                        Console.WriteLine("Insertar Carrera");
                        carrera = Console.ReadLine();
                        p.insertarCarrera(carrera);
                        break;
                    case 2:
                        edad = pi.eliminarEdad();
                        nombre = p.eliminarNombre();
                        sexo = p.eliminarNombre();
                        carrera = p.eliminarNombre();
                        Console.WriteLine("Eliminado Nombre " + nombre);
                        Console.WriteLine("Eliminado edad " + edad);
                        Console.WriteLine("Eliminado sexo " + sexo);
                        Console.WriteLine("Eliminado carrera " + carrera);
                        Console.ReadKey();
                        break;
                    case 3:

                        p.mostrar();
                        pi.mostrar();
                        Console.ReadKey();
                        break;
                    case 4:

                        break;
                }
            }
        }
    }
}
