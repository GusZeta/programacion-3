using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    class aula
    {
       
       private List<alumno> ListaAlumnos;
       public void insertar(alumno alu)
        {
            ListaAlumnos.Add(alu);
        }
        public Boolean eliminar(alumno alu)
        {
           return ListaAlumnos.Remove(alu);               
        }
        public List<alumno> GetVarones()
        {
            List<alumno> aux = new List<alumno>();
            var consulta2 = from al in ListaAlumnos
                            where al.Sexo == "M"
                            select al;
            foreach (alumno p in consulta2)
            {
                aux.Add(p);
            }

            return aux ;
        }
        
       
    }
        class alumno
        {
            public String Nombre { set; get; }
            public String Sexo { set; get; }
            public int Edad { set; get; }
            public String Carrera { set; get; }
            public alumno(string pnombre, string psexo, int pedad, string pcarrera)
            {
                Nombre = pnombre;

                Sexo = psexo;
                Edad = pedad;
                Carrera = pcarrera;

            }
           
        }
       
    
}
