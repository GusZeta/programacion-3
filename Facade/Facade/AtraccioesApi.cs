using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class AtraccionesApi
    {
        public void buscarAtracciones(String fechaEntrada, String fechaSalida, String destino)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Atracciones encontradas");
            Console.WriteLine("Entrada: " + fechaEntrada + " Salida: " + fechaSalida);
            Console.WriteLine("Atraccion A");
            Console.WriteLine("Atraccion B");
            Console.WriteLine("Atraccion C");
            Console.WriteLine("==============================");
        }

    }
}
