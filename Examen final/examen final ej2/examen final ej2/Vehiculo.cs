using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace examen_final_ej2
{
    class Vehiculo
    {
        private string placa;
        private string tipo;
        private int monto;
        private int entrada;
        private int salida;

        public string Placa { get => placa; set => placa = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Monto { get => monto; set => monto = value; }
        public int Entrada { get => entrada; set => entrada = value; }
        public int Salida { get => salida; set => salida = value; }

        public Vehiculo(string Placa, string Tipo, int Monto, int Entrada, int Salida)
        {
            this.Placa = Placa;
            this.Tipo = Tipo;
            this.Monto = Monto;
            this.Entrada = Entrada;
            this.Salida = Salida;
        }
    }
}