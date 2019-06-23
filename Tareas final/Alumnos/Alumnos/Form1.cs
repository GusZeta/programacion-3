using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumnos
{
    public partial class Form1 : Form
    {
        private List<alumno> alum =new List<alumno>();
        private List<aula> alu = new List<aula>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sexo = "";
            if (rbm.Checked)
            {
                sexo = "M";
            }
            else
            {
                sexo = "F";
            }
            alumno a = new alumno(txtnombre.Text, sexo, int.Parse(txtedad.Text), cbcarrera.Text);
            alum.Add(a);
            agregardgv();
        }

        private void agregardgv()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = alum;
            
        }
        private void consul()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = alu;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            aula x = new aula();
            x.GetVarones();
            dataGridView1.DataSource = x.GetVarones();
            
        }
    }
}
