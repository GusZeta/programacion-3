using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_final_ej_1
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
    class Parqueo
    {
        private List<Vehiculo> ListaVehiculos;
        public void insertar(Vehiculo ve)
        {
            ListaVehiculos.Add(ve);
        }
        public List<Vehiculo> GetMotos()
        {
            List<Vehiculo> aux = new List<Vehiculo>();
            var consulta1 = from v in ListaVehiculos
                            group v by v.Tipo=="Moto" into tipo
                            select tipo;
            foreach (Vehiculo ve in consulta1)
            {
                aux.Add(ve);
            }
            
            return aux;
        }
        public List<Vehiculo> GetNTipo()
        {
            List<Vehiculo> aux = new List<Vehiculo>();
            var consulta2 = from v in ListaVehiculos
                            group v by v.Tipo into tipo
                            select new { tipo = tipo.Key, cantidad = tipo.Count() };
            foreach (Vehiculo ve in consulta2)
            {
                aux.Add(ve);
            }
            return aux;
        }
        public List<Vehiculo> GetMonto()
        {
            List<Vehiculo> aux = new List<Vehiculo>();
            var consulta3 = from v in ListaVehiculos
                            group v by v.Monto > 10 into monto
                            select new { monto = monto.Key, cantidad = monto.Count() };
            foreach (Vehiculo ve in consulta3)
            {
                aux.Add(ve);
            }
            return aux;
        }
    }
}
