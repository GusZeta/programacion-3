using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


namespace _2do_parcial_p3_cliente
{
    class ahorcado
    {
        private static readonly string[] Palabras = { "Computacion", "Español", "Eucalipto", "Orquidea" };
        private String PalabraAdivinar;
        private List<char> Letras;
        public int Estado { get; private set; }
        private String Guiones;
        private static ahorcado Instancia;  
        private ahorcado()
        { 
            Iniciar();
        }
        public void Iniciar()
        {
            Estado = 0;
            Letras = new List<char>();
            Random rnd = new Random();
            int indice = rnd.Next(3);
            PalabraAdivinar = Palabras[indice];
            Guiones = "";
            Guiones = Guiones.PadLeft(PalabraAdivinar.Count(), '_');
        }
        public String Buscar(char Letra)
        {
            Letras.Add(Letra);
            String aux = "";
            if (PalabraAdivinar.Contains(Letra.ToString()))
            {
                for (int i = 0; i < PalabraAdivinar.Count(); i++)
                {

                    if (PalabraAdivinar[i] == Letra)
                    {
                        aux += Letra;
                    }
                    else
                    {
                        aux += Guiones[i];
                    }
                }
                Guiones = aux;
                return aux;
            }
            else
            {
                return Estado.ToString();
            }
        }
        public Boolean BuscarPalabra(String Palabra)
        {
            if (Palabra == PalabraAdivinar)
                return true;
            else
            {
                Estado++;
                return false;
            }
        }

        public static ahorcado getInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new ahorcado();
            }
            return Instancia;
        }
    }
}
