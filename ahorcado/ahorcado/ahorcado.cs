using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ahorcado
{
    class ahorcado
    {
        private static readonly string[] Palabras = {"Computacion", "Español", "Eucalipto", "Orquidea"};
        private String Palabraadivinar;
        private List<char> letras;
        public int estado { get; private set; }
        private String Guiones;
        private static ahorcado Instancia;
        private ahorcado()
        {
            Iniciar();
        }
        public void Iniciar()
        {
            estado = 0;
            letras = new List<char>();
            Random rnd = new Random();
            int indice = rnd.Next(3);
            Palabraadivinar = Palabras[indice];
            Guiones = "";
            Guiones.PadLeft(Palabraadivinar.Count(), '-');
        }
        public String buscar(char letra)
        {
            letras.Add(letra);
            String aux = "";
            if (Palabraadivinar.Contains(letra.ToString()))
            {
                for (int i = 0; i < Palabraadivinar.Count(); i++)
                {
                    if (Palabraadivinar[i] == letra)
                    {
                        aux += letra;
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
                return estado.ToString();
            }
           
        }
        public Boolean buscarpalabra(String Palabra)
        {
            if (Palabra == Palabraadivinar)
            { return true; }
            else
            {
                estado++;
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
