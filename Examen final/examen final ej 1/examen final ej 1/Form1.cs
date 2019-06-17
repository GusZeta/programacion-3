using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen_final_ej_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnvehiculos_Click(object sender, EventArgs e)
        {
            Vehiculo[] vehiculo = new Vehiculo[10];
            string p = txtplaca.Text;
            string t = cbtipo.Text;
            int m = 0;
            int hi = int.Parse(txtentrada.Text);
            int hs = int.Parse(txtsalida.Text);
            if (rbauto.Checked == true)
            { m = (hs - hi) * 2; }
            if (rbvagoneta.Checked == true)
            { m = (hs - hi) * 4; }
            if (rbmoto.Checked == true)
            { m = (hs - hi) * 1; }
            if (rbcamion.Checked == true)
            { m = (hs - hi) * 5; }
            if (rbjeep.Checked == true)
            { m = (hs - hi) * 3; }
            if (rbotro.Checked == true)
            { m = (hs - hi) * 6; }
            lstvehiculo.Items.Add("placa " + p);
            lstvehiculo.Items.Add(t);
            lstvehiculo.Items.Add("monto a cobrar " + m);
            lstvehiculo.Items.Add("Hora de Entrada " + hi);
            lstvehiculo.Items.Add("Hora de Salida" + hs);
            lstvehiculo.Items.Add("******************************");
        }

        private void btnconsultas_Click(object sender, EventArgs e)
        {
            
            string p = txtplaca.Text;
            string t = cbtipo.Text;
            int m = 0;
            int hi = int.Parse(txtentrada.Text);
            int hs = int.Parse(txtsalida.Text);
            if (rbauto.Checked == true)
            { m = (hs - hi) * 2; }
            if (rbvagoneta.Checked == true)
            { m = (hs - hi) * 4; }
            if (rbmoto.Checked == true)
            { m = (hs - hi) * 1; }
            if (rbcamion.Checked == true)
            { m = (hs - hi) * 5; }
            if (rbjeep.Checked == true)
            { m = (hs - hi) * 3; }
            if (rbotro.Checked == true)
            { m = (hs - hi) * 6; }
            for (int i = 0; i < 7; i++)
            {
                Vehiculo vehiculo = new Vehiculo(p, t, m, hi, hs);
            }
            
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            Parqueo parq = new Parqueo();
            lstconsultas.Items.Add(parq.GetMotos());
        }
    }
}