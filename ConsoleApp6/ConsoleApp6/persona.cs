using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class persona
    {
        public string nombre;
        public string apellido;
        public int edad;
        public string sexo;
        public string CI;
        public double altura;
        public double peso;
        public persona(string nombre, string apellido, int edad, string sexo, string CI, double altura, double peso)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.sexo = sexo;
            this.CI = CI;
            this.altura = altura;
            this.peso = peso;
        }
    }
}
