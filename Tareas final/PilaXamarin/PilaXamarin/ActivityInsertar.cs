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
    [Activity(Label = "ActivityInsertar")]
    public class ActivityInsertar : Activity
    {
        Pila<string> pi = new Pila<string>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            // Create your application here
            SetContentView(Resource.Layout.InsertaLO);

            EditText numero = FindViewById<EditText>(Resource.Id.txtintroducir);
            Button agregar = FindViewById<Button>(Resource.Id.btnAgregar);
            
            
            agregar.Click += btnAgregar_Click;
            void btnAgregar_Click(object sender, System.EventArgs e)
            {
                string valor = numero.Text;
                pi.push(valor);
            }
            Button Salir = FindViewById<Button>(Resource.Id.btnsalir);
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