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
        const String ruta1 = "C:\\Users\\Estudiante\\programacion-3\\2do parcial\\2do parcial p3 cliente\\1.png";
        const String ruta2 = "C:\\Users\\Estudiante\\programacion-3\\2do parcial\\2do parcial p3 cliente\\2.png";
        const String ruta3 = "C:\\Users\\Estudiante\\programacion-3\\2do parcial\\2do parcial p3 cliente\\3.png";
        const String ruta4 = "C:\\Users\\Estudiante\\programacion-3\\2do parcial\\2do parcial p3 cliente\\4.png";
        const String ruta5 = "C:\\Users\\Estudiante\\programacion-3\\2do parcial\\2do parcial p3 cliente\\5.png";
        const String ruta6 = "C:\\Users\\Estudiante\\programacion-3\\2do parcial\\2do parcial p3 cliente\\6.png";
        const String ruta7 = "C:\\Users\\Estudiante\\programacion-3\\2do parcial\\2do parcial p3 cliente\\7.png";
        const String ruta8 = "C:\\Users\\Estudiante\\programacion-3\\2do parcial\\2do parcial p3 cliente\\8.png";
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
