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
using static Android.App.ActionBar;

namespace PilaXamarin
{
    [Activity(Label = "Mostrar")]
    public class Mostrar : Activity
    {
        Pila<string> pi = new Pila<string>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Mostrar);
            ListView lista = FindViewById<ListView>(Resource.Id.listMostrar);
            Button Mostrar = FindViewById<Button>(Resource.Id.btnmostra);
            
            
            Button Salir = FindViewById<Button>(Resource.Id.btnsalir);
            Salir.Click += btnSalir_Click;
            void btnSalir_Click(object sender, System.EventArgs e)
            {
                var Volver = new Intent(this, typeof(MainActivity));
                Volver.PutExtra("Datos", "Datos Enviados");
                StartActivity(Volver);
            }
            Mostrar.Click += mostrar;
            void mostrar(object sender, System.EventArgs e)
            {
                string[] array = pi.mostrar();
                for (int i = 0; i < array.Length; i++)
                {
                var editText = new EditText(this);

                var layoutParams = new LinearLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.WrapContent);
                layoutParams.BottomMargin = 6;

                editText.LayoutParameters = layoutParams;
                
                    editText.Hint = array[i];

                    lista.AddView(editText);

                }
            }
        }
    }
}