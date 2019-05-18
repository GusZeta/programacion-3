using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2do_parcial_p1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnobtener_Click(object sender, EventArgs e)
        {
            banco v = banco.getInstance();
            lblcotizacion.Text = v.obtenercotizacion().ToString();

        }

        private void btncolocar_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtcotizacion.Text);
            banco x = banco.getInstance();
            x.colocarcotizacion(Convert.ToDouble(txtcotizacion.Text));
        }
    }
}
