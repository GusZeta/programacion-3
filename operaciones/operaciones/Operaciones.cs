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

namespace operaciones
{
    class Operaciones
    {
        private static Operaciones Instancia;
        public int factorial(int x)
        {
            if (x == 0)
                return 1;
            else
                return factorial(x - 1) * x;
        }
        public int sumatoria(int x)
        {
            if (x == 0)
                return 0;
            else
                return sumatoria(x - 1) + x;
        }
        public static Operaciones getInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new Operaciones();
            }
            return Instancia;
        }
    }
}