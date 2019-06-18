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

namespace CalculadoraAndroid
{
    class CalculadoraFinanciera
    {
        int n;
        double tasa;
        public CalculadoraFinanciera(int periodos, double i)
        {
            this.n = periodos;
            this.tasa = i;
        }
        public double Montofinal(double Montoinicial)
        {
            double CF = 0;
            CF = Montoinicial * (Math.Pow((1 + tasa), n));
            return CF;
        }
        public double VAN(double Io, double[] flujos)
        {
            double va = 0;
            double final;
            for (int i = 0; i < n; i++)
            {
                va += flujos[i] / (Math.Pow((1 + tasa), i));
            }
            final = va - Io;
            return final;
        }
    }
}