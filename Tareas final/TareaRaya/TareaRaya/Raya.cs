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

namespace TareaRaya
{
    class Raya
    {
        private static Raya Instancia;
        private Char[,] tabla;
        private int turno;
        private Raya()
        {
            turno = 1;
            tabla = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                { tabla[i, j] = '-'; }
            }
        }

        public static Raya getInstancia()
        {
            if (Instancia == null)
                Instancia = new Raya();

            return Instancia;
        }
        public void Reiniciar()
        {
            turno = 1;
            tabla = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                { tabla[i, j] = '-'; }
            }
        }

        public String marcar(int x, int y, Char marca)
        {
            int turnomarcacion = 0;
            if (marca == 'x')
                turnomarcacion = 1;
            else
                turnomarcacion = 2;
            // verificar si el turno corresponde
            if (turnomarcacion == turno)
            {
                // si esta vacio marcar
                if (tabla[x, y] == '-')
                {
                    tabla[x, y] = marca;
                    // verificar si hy ganador
                    if (ganador(marca))
                    {
                        return "ganador:" + marca.ToString();
                    }
                    else
                    {
                        // verificar si hay empate
                        if (empate())
                        {
                            return "resultado:empate";
                        }
                        else
                        {
                            // pasar el turno
                            turno = (turno % 2) + 1;
                            return "continuar:juego";
                        }
                    }

                }
                else
                    return "error:posicion ocupada";
            }
            else
                return "error:turno incorrecto";
        }

        private Boolean ganador(char marca)
        {
            Boolean bganador = false;
            // verificar si hay ganador por filas
            if (tabla[0, 0] == marca && tabla[0, 1] == marca && tabla[0, 2] == marca)
                bganador = true;
            if (tabla[1, 0] == marca && tabla[1, 1] == marca && tabla[1, 2] == marca)
                bganador = true;
            if (tabla[2, 0] == marca && tabla[2, 1] == marca && tabla[2, 2] == marca)
                bganador = true;
            // verificar sihay ganadorpor columnas
            if (tabla[0, 0] == marca && tabla[1, 0] == marca && tabla[2, 0] == marca)
                bganador = true;
            if (tabla[0, 1] == marca && tabla[1, 1] == marca && tabla[2, 1] == marca)
                bganador = true;
            if (tabla[0, 2] == marca && tabla[1, 2] == marca && tabla[2, 2] == marca)
                bganador = true;
            // verificar diagonales
            if (tabla[0, 0] == marca && tabla[1, 1] == marca && tabla[2, 2] == marca)
                bganador = true;
            if (tabla[2, 0] == marca && tabla[1, 1] == marca && tabla[0, 2] == marca)
                bganador = true;
            return bganador;

        }
        private Boolean empate()
        {
            Boolean bempate = true;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (tabla[i, j] == '-')
                        bempate = false;
            return bempate;
        }

    }
}