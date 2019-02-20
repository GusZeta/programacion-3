using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            persona[] alumnos = new persona[7];
            alumnos[0] = new persona("Diego", "La Torre", 18, "masculino", "41234124", 1.74, 68);
            alumnos[1] = new persona("Alejandro", "Castro", 19, "masculino", "5345345", 1.69, 67);
            alumnos[2] = new persona("Franco", "Adamczyk", 18, "masculino", "742482656", 1.80, 65);
            alumnos[3] = new persona("Dieter", "Quiñones", 19, "masculino", "53453453534", 1.72, 57);
            alumnos[4] = new persona("Carolina", "Lopez", 18, "femenino", "59545940", 1.74, 68);
            alumnos[5] = new persona("Rossimar", "Guzman", 18, "femenino", "58456642", 1.40, 70);
            alumnos[6] = new persona("Gustavo", "Zarate", 19, "masculino", "12577699", 1.85, 65);
            var consulta1 = from alm in alumnos
                            select alm;
            var consulta2 = from alm in alumnos
                            where alm.edad > 18
                            select alm;
            var consulta3 = from alm in alumnos
                            orderby alm.apellido
                            select new { alm.nombre, alm.apellido };
            var consulta4 = from alm in alumnos
                            orderby alm.apellido, alm.apellido descending
                            select alm;

            var consulta5 = from alm in alumnos
                            group alm by alm.edad into edad
                            select edad;
           
            var consulta7 = from alm in alumnos
                            group alm by alm.edad  into edad
                            select new {Edad= edad.Key, Cantidad = edad.Count()};
            var consulta8 = from alm in alumnos
                            orderby alm.apellido, alm.apellido descending
                            select alm;
            foreach (var grupoapellido in consulta8)
            {
                Console.WriteLine("{0} {1}", grupoapellido.nombre, grupoapellido.apellido);
            }
            Console.WriteLine("*********************************************************");
            var consulta12 = from alm in alumnos
                            where alm.edad > 18 && alm.sexo=="masculino"
                            orderby alm.edad,alm.sexo
                             select alm;
            foreach (var grupe in consulta12)
            {
                Console.WriteLine("{0} {1} {2}", grupe.nombre, grupe.edad, grupe.sexo);
            }
            Console.WriteLine("*********************************************************");
            var consulta9 = from alm in alumnos
                            group alm by alm.sexo into sexo
                            select sexo;
            foreach (var GrupoSexo in consulta9)
            {
                Console.WriteLine(GrupoSexo.Key);
                foreach (persona alum in GrupoSexo)
                {
                    Console.WriteLine("{0} {1}", alum.nombre, alum.sexo);
                }
            }
            Console.WriteLine("*********************************************************");
            var consulta10 = from alm in alumnos
                             group alm by alm.sexo into sexo
                             select new { Sexo = sexo.Key, Cantidad = sexo.Count() };
            foreach (var gruposexo in consulta10)
            {
                Console.WriteLine("{0} {1}", gruposexo.Sexo, gruposexo.Cantidad);
            }
            Console.WriteLine("*********************************************************");
            var consulta11 = from alm in alumnos
                             group alm by alm.sexo into sexos
                             select new { Sexo = sexos.Key, Promedio = sexos.Average(pe => pe.edad) };
            foreach (var gp in consulta11)
            {
                Console.WriteLine("{0} {1}", gp.Sexo, gp.Promedio);
            }

            Console.ReadKey();
        }                   
    }
    
}
