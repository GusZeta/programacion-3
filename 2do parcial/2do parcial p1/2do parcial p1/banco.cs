using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2do_parcial_p1
{
    class banco
    {
        private Double cotizacion = 0;
        private static banco instance;
        private banco()
        {

        }
        public void colocarcotizacion(Double x)
        {
            cotizacion = x; 
        }
        
        public static banco getInstance()
        {
            if (instance == null)
                instance = new banco();

            return instance;
        }
        public Double obtenercotizacion()
        {
            return cotizacion;
        }
    }
}
