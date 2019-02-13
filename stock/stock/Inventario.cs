using System;
using System.Collections.Generic;
using System.Text;

namespace stock
{
    class Inventario
    {
        public delegate void delegado (int n);
        public event delegado stockminimo;
        private int stock;
        public Inventario()
        {
            this.stock = 0;
        }
        public void incrementarstock(int n)
        {
            this.stock += n;
            if (this.stock < 5 && stockminimo != null)
            {
                stockminimo(this.stock);
            }
        }
        public void disminuirstock(int n)
        {
            if (this.stock < n)
            {
                Console.WriteLine("No se dispone de esa cantidad");
            }
            else
            {
                this.stock -= n;
            }
            if (this.stock < 5 && stockminimo != null)
            {
                stockminimo(this.stock);
            }
        }
        public void mostrarstock()
        {
            Console.WriteLine("el stock actual es: {0}", this.stock);
        }
        

    }
}
