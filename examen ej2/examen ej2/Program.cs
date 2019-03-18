using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_ej2
{
    class Program
    {
        static void Main(string[] args)
        {

            docente[] Docente = new docente[4];
            Docente[0] = new docente("Juan", "Perez","Masculino", 35, "Ing.Industrial","Diniosio, Pedro, Juan");
            Docente[1] = new docente("Maria", "Gomez", "Femenino", 33, "Ing.Civil","Marcela, Ricardo, Maria");
            Docente[2] = new docente("Pedro", "Vaca", "Masculino", 35, "Ing.Civil","Marcela");
            Docente[3] = new docente("Marta", "Aramayo", "Femenino", 40, "Ing.Industrial","Diniosio, Pedro, Juan");

            var consulta1 = from dos in Docente
                            orderby dos.Apellido, dos.Apellido descending
                            orderby dos.Edad,dos.Edad descending
                            select dos;
            foreach (var grupoapellido in consulta1)
            {
                Console.WriteLine("{0} {1}", grupoapellido.Apellido, grupoapellido.Edad);
            }
            Console.WriteLine("************************************************************************");
            var consulta2 = from dos in Docente
                            where dos.Edad <35
                            select dos;
            foreach (var grupoedad in consulta2)
            {
                Console.WriteLine("{0}", grupoedad.Nombre);
            }
            Console.WriteLine("************************************************************************");
            var consulta3 = from dos in Docente
                            group dos by dos.Carrera into Carrera
                            select Carrera;
            foreach (var GrupoCarrera in consulta3)
            {
                Console.WriteLine(GrupoCarrera.Key);
                foreach (docente doc in GrupoCarrera)
                {
                    Console.WriteLine("{0} {1}", doc.Nombre, doc.Carrera);
                }
            }
            Console.WriteLine("************************************************************************");
            var consulta9 = from dos in Docente
                            group dos by dos.Sexo into Sexo
                            select Sexo;
            foreach (var GrupoSexo in consulta9)
            {
                Console.WriteLine(GrupoSexo.Key);
                foreach (docente doc in GrupoSexo)
                {
                    Console.WriteLine("{0} {1}", doc.Nombre, doc.Sexo);
                }
            }
            Console.ReadKey();

        }
    }
}
