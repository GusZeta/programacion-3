using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Financiera
{
    class CalculadoraF
    {
        int n;
        double tasa;
        public void calculadorafinanciera(int periodos, double i)
        {

        }
        public double MontoFinal(double MontoInicial)
        {
            return (MontoInicial *Math.Pow((1 + tasa), n));
        }
        public double VAN(double Io, double[] flujos)
        {
            for (int i = 1; i <= n; i++)
            {
               Io= flujos[i] /Math.Pow((1 + tasa), i);
                Io++;
            }
            return Io;
        }
    }
    
}
