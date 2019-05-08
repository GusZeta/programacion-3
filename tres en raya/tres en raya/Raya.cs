using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tres_en_raya
{
    class Raya
    {
        private static Raya Instancia;
        private Char[,] tabla;
        private int turno;
        public Raya()
        {
            turno = 1;
            tabla = new char[3, 3];
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    tabla[i, j] = '-';
                }
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
                {
                    tabla[i, j] = '-';
                }
            }
        }
        public String marcar(int x, int y, char marca)
        {
            int turnomarca=0;
            if (marca == 'X')
            {
                turnomarca = 1;
            }
            else
            {
                turnomarca = 2;
            }
            if (turnomarca == turno)
            {
                if (tabla[x, y] == '-')
                {
                    tabla[x, y] = marca;
                    if (ganador(marca))
                    {
                        return "Ganador: X";
                    }
                    else
                    {
                        if (Empate())
                        {
                            return "Empate";
                        }
                        else
                        {
                            turno = (turno % 2) + 1;
                            return "Continuar";
                        }
                    }
                }
                else
                {
                    return "Error: posicion ocupada";
                }
            }

            else
            {
                return "Error: turno incorrecto";
            }  
            
        }
        public Boolean ganador(char marca)
        {
            bool ganar = false;
            if (tabla[0, 0] == marca && tabla[0, 1] == marca && tabla[0, 2] == marca)
            {
                ganar = true;
            }
            if (tabla[1, 0] == marca && tabla[1, 1] == marca && tabla[1, 2] == marca)
            {
                ganar = true;
            }
            if (tabla[2, 0] == marca && tabla[2, 1] == marca && tabla[2, 2] == marca)
            {
                ganar = true;
            }
            if (tabla[0, 0] == marca && tabla[1, 0] == marca && tabla[2, 0] == marca)
            {
                ganar = true;
            }
            if (tabla[0, 1] == marca && tabla[1, 1] == marca && tabla[2, 1] == marca)
            {
                ganar = true;
            }
            if (tabla[0, 2] == marca && tabla[1, 2] == marca && tabla[2, 2] == marca)
            {
                ganar = true;
            }
            if (tabla[0, 0] == marca && tabla[1, 1] == marca && tabla[2, 2] == marca)
            {
                ganar = true;
            }
            if (tabla[2, 0] == marca && tabla[1, 1] == marca && tabla[0, 2] == marca)
            {
                ganar = true;
            }
            return ganar;
        }
        public Boolean Empate()
        {
            bool empate = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tabla[i, j] == '-')

                    {
                        empate = false;
                    }
                }
            }
            return empate;
        }
        

    }
}
