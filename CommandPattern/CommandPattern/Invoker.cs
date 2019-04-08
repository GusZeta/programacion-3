using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Invoker
    {

        private List<IOperacion> operaciones = new List<IOperacion>();

        public void recibirOperacion(IOperacion operacion)
        {
            this.operaciones.Add(operacion);
        }

        public void realizarOperaciones()
        {
            this.operaciones.ForEach(x=>x.execute());

            /*
            foreach (IOperacion o in operaciones)
            {
                o.execute();
            } 
             */
            this.operaciones.Clear();
        }

    }
}
