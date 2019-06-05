using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace juego
{
    class ahorcado
    {
        private static readonly string[] Palabras = { "computacion", "español", "eucalipto", "orquidea" };
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
            Guiones = Guiones.PadLeft(PalabraAdivinar.Count(), '-');
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
                Estado++;
                return Guiones;
            }
        }
        public String BuscarPalabra(String Palabra)
        {
            if (Palabra == PalabraAdivinar)
            {
                Guiones = PalabraAdivinar;
            }
            else
            {
                Estado++;
            }
            return Guiones;

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