using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace app
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            EditText A = FindViewById<EditText>(Resource.Id.lblA);
            EditText B = FindViewById<EditText>(Resource.Id.editText1);
            Button Calcular = FindViewById<Button>(Resource.Id.button1);
            TextView Resultado = FindViewById<TextView>(Resource.Id.txtResultado);
            Calcular.Click += (sender, e) =>
              {
                  int a = int.Parse(A.Text);
                  int b = int.Parse(B.Text);
                  Resultado.Text = (a + b).ToString();
              };
        }
    }
    
}