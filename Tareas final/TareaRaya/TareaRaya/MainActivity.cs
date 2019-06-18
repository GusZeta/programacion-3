using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace TareaRaya
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            ImageView cerocero = FindViewById<ImageView>(Resource.Id.imageView1);
            ImageView cerouno = FindViewById<ImageView>(Resource.Id.imageView2);
            ImageView cerodos = FindViewById<ImageView>(Resource.Id.imageView3);
            ImageView unocero = FindViewById<ImageView>(Resource.Id.imageView4);
            ImageView unouno = FindViewById<ImageView>(Resource.Id.imageView5);
            ImageView unodos = FindViewById<ImageView>(Resource.Id.imageView6);
            ImageView doscero = FindViewById<ImageView>(Resource.Id.imageView7);
            ImageView dosuno = FindViewById<ImageView>(Resource.Id.imageView8);
            ImageView dosdos = FindViewById<ImageView>(Resource.Id.imageView9);
            Button reiniciar = FindViewById<Button>(Resource.Id.btnReiniciar);
            TextView turno = FindViewById<TextView>(Resource.Id.textView2);
            TextView mensaje = FindViewById<TextView>(Resource.Id.lblmensaje);
            turno.Text = "x";
            void AnalizaMensage(string mensaj)
            {
                string[] respuesta = mensaj.Split(':');
                switch (respuesta[0])
                {
                    case "ganador":
                        mensaje.Text = "el ganador es: " + respuesta[1];
                        break;
                    case "continuar":
                        if (turno.Text == "x")
                            turno.Text = "o";
                        else
                            turno.Text = "x";
                        break;
                    case "error":
                        mensaje.Text = "error: " + respuesta[1];
                        break;
                    case "resultado":
                        mensaje.Text = "Hubo un empate";

                        break;

                }
            }


            reiniciar.Click += (sender, e) =>
            {

                TareaRaya.Raya.getInstancia().Reiniciar();
                cerocero.SetImageResource(Resource.Drawable.blanco);
                cerouno.SetImageResource(Resource.Drawable.blanco);
                cerodos.SetImageResource(Resource.Drawable.blanco);
                unocero.SetImageResource(Resource.Drawable.blanco);
                unouno.SetImageResource(Resource.Drawable.blanco);
                unodos.SetImageResource(Resource.Drawable.blanco);
                doscero.SetImageResource(Resource.Drawable.blanco);
                dosuno.SetImageResource(Resource.Drawable.blanco);
                dosdos.SetImageResource(Resource.Drawable.blanco);
                turno.Text = "x";
            };

            cerocero.Click += (sender, e) =>
            {
               
               string respuesta= TareaRaya.Raya.getInstancia().marcar(0,0,turno.Text[0]);
                if (turno.Text == "x")
                    cerocero.SetImageResource(Resource.Drawable.equisd);
                else
                    cerocero.SetImageResource(Resource.Drawable.o);
                AnalizaMensage(respuesta);


            };
            cerouno.Click += (sender, e) =>
            {
                
                string respuesta= TareaRaya.Raya.getInstancia().marcar(0, 1, turno.Text[0]);
                if (turno.Text == "x")
                    cerouno.SetImageResource(Resource.Drawable.equisd);
                else
                    cerouno.SetImageResource(Resource.Drawable.o);
                AnalizaMensage(respuesta);

            };
            cerodos.Click += (sender, e) =>
            {

                
              string respuesta=  TareaRaya.Raya.getInstancia().marcar(0, 2, turno.Text[0]);
                if (turno.Text == "x")
                    cerodos.SetImageResource(Resource.Drawable.equisd);
                else
                    cerodos.SetImageResource(Resource.Drawable.o);
                AnalizaMensage(respuesta);
            };
            unocero.Click += (sender, e) =>
            {
                
              string respuesta=  TareaRaya.Raya.getInstancia().marcar(1, 0, turno.Text[0]);
                if (turno.Text == "x")
                    unocero.SetImageResource(Resource.Drawable.equisd);
                else
                    unocero.SetImageResource(Resource.Drawable.o);
                AnalizaMensage(respuesta);

            };
            unouno.Click += (sender, e) =>
            {
                
              string respuesta=  TareaRaya.Raya.getInstancia().marcar(1, 1, turno.Text[0]);
                if (turno.Text == "x")
                    unouno.SetImageResource(Resource.Drawable.equisd);
                else
                    unouno.SetImageResource(Resource.Drawable.o);
                AnalizaMensage(respuesta);

            };
            unodos.Click += (sender, e) =>
            {
               
              string respuesta=  TareaRaya.Raya.getInstancia().marcar(1, 2, turno.Text[0]);
                if (turno.Text == "x")
                    unodos.SetImageResource(Resource.Drawable.equisd);
                else
                    unodos.SetImageResource(Resource.Drawable.o);
                AnalizaMensage(respuesta);

            };
            doscero.Click += (sender, e) =>
            {
               
               string respuesta = TareaRaya.Raya.getInstancia().marcar(2, 0, turno.Text[0]);
                if (turno.Text == "x")
                    doscero.SetImageResource(Resource.Drawable.equisd);
                else
                    doscero.SetImageResource(Resource.Drawable.o);
                AnalizaMensage(respuesta);

            };
            dosuno.Click += (sender, e) =>
            {
               
              string respuesta=  TareaRaya.Raya.getInstancia().marcar(2, 1, turno.Text[0]);
                if (turno.Text == "x")
                    dosuno.SetImageResource(Resource.Drawable.equisd);
                else
                    dosuno.SetImageResource(Resource.Drawable.o);
                AnalizaMensage(respuesta);

            };
            dosdos.Click += (sender, e) =>
            {
               
               string respuesta= TareaRaya.Raya.getInstancia().marcar(2, 2, turno.Text[0]);
                if (turno.Text == "x")
                    dosdos.SetImageResource(Resource.Drawable.equisd);
                else
                    dosdos.SetImageResource(Resource.Drawable.o);
                AnalizaMensage(respuesta);

            };
            

        }
        
    }
}