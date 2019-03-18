using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_ej2
{
    class docente
    {
        private string nombre;
        private string apellido;
        private string sexo;
        private int edad;
        private string carrera;
        private string alumnos;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public string Alumnos { get => alumnos; set => alumnos = value; }

        public docente(string Nombre, string Apellido,string Sexo, int Edad, string Carrera,string Alumnos)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Edad = Edad;
            this.Sexo = Sexo;
            this.Carrera = Carrera;
            this.Alumnos = Alumnos;
        }
    }
}
