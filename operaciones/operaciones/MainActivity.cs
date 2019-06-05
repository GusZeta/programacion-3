using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace operaciones
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            EditText numero = FindViewById<EditText>(Resource.Id.txtnum);
            RadioButton rf = FindViewById<RadioButton>(Resource.Id.rdbtnfact);
            RadioButton rs = FindViewById<RadioButton>(Resource.Id.rdbtnsum);
            Button calcular = FindViewById<Button>(Resource.Id.btncalcular);
            TextView resultado = FindViewById<TextView>(Resource.Id.lblnum);
            calcular.Click += (sender, e) =>
            {
                int x = int.Parse(numero.Text);
                int res;
                if (rf.Checked == true)
                {
                    res = operaciones.Operaciones.getInstancia().factorial(x);
                    resultado.Text = res.ToString();
                }
                if (rs.Checked == true)
                {
                    res = operaciones.Operaciones.getInstancia().sumatoria(x);
                    resultado.Text = res.ToString();
                }
            };
        }
    }
}