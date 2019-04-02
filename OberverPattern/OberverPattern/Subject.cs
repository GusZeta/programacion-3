using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OberverPattern
{
    class Subject
    {
        private List<Observador> observadores = new List<Observador>();
        private int estado;

        public int getEstado()
        {
            return estado;
        }

        public void setEstado(int estado)
        {
            this.estado = estado;
            notificarTodosObservadores();  //dispador
        }

        public void agregar(Observador observador)
        {
            observadores.Add(observador);
        }

        public void notificarTodosObservadores()
        {
            observadores.ForEach(x=>x.actualizar());
        }


    }
}
