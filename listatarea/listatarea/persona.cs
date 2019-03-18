using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listatarea
{
    class Docentes
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string carrera;

        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Carrera { get => carrera; set => carrera = value; }

        public Docentes(string Nombre, string Apellido, int Edad, string Carrera)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Edad = Edad;
            this.Carrera = Carrera;
        }
    }
}
