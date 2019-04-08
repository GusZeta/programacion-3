using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class MostrarImp:IOperacion
    {
        private Cuenta cuenta;
        private double monto;

        public MostrarImp(Cuenta cuenta)
        {
            this.cuenta = cuenta;
            
        }

        public void execute()
        {
            this.cuenta.mostrar(this.monto);
        }

    }
}
