using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listatarea
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Docentes[] Docente = new Docentes[4];
            Docente[0] = new Docentes("Diego", "La Torre", 65, "Ing en sistemas");
            Docente[1] = new Docentes("Vicente", "Fernandez", 35, "Ing en sistemas");
            Docente[2] = new Docentes("Mario", "Neta", 80, "Ing en sistemas");
            Docente[3] = new Docentes("Elba", "Jito", 46, "Ing en sistemas");

            Console.WriteLine("Con metodos ");

            Console.WriteLine("1.-Lista de docentes ordenados por apellido descendentemente");

            var metodo1 = Docente.OrderByDescending(p => p.Apellido);

            foreach (var p in metodo1)
            {
                Console.WriteLine("{0} {1}", p.Apellido, p.Nombre);
            }
            Console.WriteLine("********************************");
            Console.WriteLine("2.-lista de doscentes");

            var metodo2 = Docente.Where(p => p.Edad > 60);
            foreach (var p in metodo2)
            {
                Console.WriteLine("{0}", p.Nombre);
            }
            Console.WriteLine("************************");
            Console.WriteLine("3.-Cantidad de alumnos por edad");
            var metodo4 = Docente.GroupBy(t => new { Edad = t.Edad })
                         .Select(g => new {
                             Cantidad = g.Count(),
                             Edad = g.Key.Edad
                         });

            foreach (var grupoedad in metodo4)
            {
                Console.WriteLine("{0} {1}", grupoedad.Edad, grupoedad.Cantidad);

            }
            Console.ReadKey();

        }
    }
}
        
    

