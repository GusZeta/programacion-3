using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ahorcado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnempezar_Click(object sender, EventArgs e)
        {
            ahorcado.getInstancia().Iniciar();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            lblletra.Text = ahorcado.getInstancia().buscar(txtletra.Text[0]);
        }

        private void btnenviarpalabra_Click(object sender, EventArgs e)
        {

        }
    }
}
