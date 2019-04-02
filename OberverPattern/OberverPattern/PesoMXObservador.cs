using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OberverPattern
{
    class PesoMXObservador:Observador
    {
        private double valorCambio = 19.07;

        public PesoMXObservador(Subject sujeto)
        {
            this.sujeto = sujeto;
            this.sujeto.agregar(this);
        }

        
        public override void actualizar()
        {
            Console.WriteLine("MX: " + (sujeto.getEstado() * valorCambio));
        }
    }
}
