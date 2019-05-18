using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2do_parcial_p3_cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ahorcado.getInstancia().Iniciar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResultado.Text = ahorcado.getInstancia().Buscar(txtLetra.Text[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
