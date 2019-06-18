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

namespace PilaXamarin
{
    [Activity(Label = "Eliminar")]
    public class Eliminar : Activity
    {
        Pila<string> pi = new Pila<string>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Eliminar);

            Button Eliminar = FindViewById<Button>(Resource.Id.btnEliminado);
            TextView NroEl = FindViewById<TextView>(Resource.Id.lbleliminado);
            Button Salir = FindViewById<Button>(Resource.Id.btnsalir);
           
            Eliminar.Click += btnEliminado_Click;
            void btnEliminado_Click(object sender, System.EventArgs e)
            {
                NroEl.Text = pi.pop();
            }
            Salir.Click += btnSalir_Click;
            void btnSalir_Click(object sender, System.EventArgs e)
            {
                var Volver = new Intent(this, typeof(MainActivity));
                Volver.PutExtra("Datos", "Datos Enviados");
                StartActivity(Volver);
            }
        }
    }
}