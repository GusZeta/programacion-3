using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OberverPattern
{
    class PesoBOLObservador:Observador
    {
        private double valorCambio = 6.96;

        public PesoBOLObservador(Subject sujeto)
        {
            this.sujeto = sujeto;
            this.sujeto.agregar(this); 
        }

        public override void actualizar()
        {
            Console.WriteLine("BOL: " + (sujeto.getEstado() * valorCambio));
        }

    }
}
