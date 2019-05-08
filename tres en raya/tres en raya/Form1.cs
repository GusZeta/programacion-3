using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tres_en_raya
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnreiniciar_Click(object sender, EventArgs e)
        {
            Raya.getInstancia().Reiniciar();
            pb00.Image = null;
            pb01.Image = null;
            pb02.Image = null;
            pb10.Image = null;
            pb11.Image = null;
            pb12.Image = null;
            pb20.Image = null;
            pb21.Image = null;
            pb22.Image = null;
            lblturno.Text = "X";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            String respuesta = Raya.getInstancia().marcar(0, 0, lblturno.Text[0]);
            if (lblturno.Text == "X")
                pb00.Image = new System.Drawing.Bitmap("C:\\Users\\Estudiante\\programacion-3\\x.png");
            else
                pb00.Image = new System.Drawing.Bitmap("C:\\Users\\Estudiante\\programacion-3\\o.png");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            String respuesta = Raya.getInstancia().marcar(0, 2, lblturno.Text[0]);
            if (lblturno.Text == "X")
                pb02.Image = new System.Drawing.Bitmap("C:\\Users\\Estudiante\\programacion-3\\x.png");
            else
                pb02.Image = new System.Drawing.Bitmap("C:\\Users\\Estudiante\\programacion-3\\o.png");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pb22_Click(object sender, EventArgs e)
        {

            String respuesta = Raya.getInstancia().marcar(2, 2, lblturno.Text[0]);
            if (lblturno.Text == "X")
                pb22.Image = new System.Drawing.Bitmap("C:\\Users\\Estudiante\\programacion-3\\x.png");
            else
                pb22.Image = new System.Drawing.Bitmap("C:\\Users\\Estudiante\\programacion-3\\o.png");
        }

        private void pb01_Click(object sender, EventArgs e)
        {
            String respuesta = Raya.getInstancia().marcar(0, 1, lblturno.Text[0]);
            if (lblturno.Text == "X")
                pb01.Image = new System.Drawing.Bitmap("C:\\Users\\Estudiante\\programacion-3\\x.png");
            else
                pb01.Image = new System.Drawing.Bitmap("C:\\Users\\Estudiante\\programacion-3\\o.png");
        }

        private void pb10_Click(object sender, EventArgs e)
        {

            String respuesta = Raya.getInstancia().marcar(1, 0, lblturno.Text[0]);
            if (lblturno.Text == "X")
                pb10.Image = new System.Drawing.Bitmap("C:\\Users\\Estudiante\\programacion-3\\x.png");
            else
                pb10.Image = new System.Drawing.Bitmap("C:\\Users\\Estudiante\\programacion-3\\o.png");
        }

        private void pb11_Click(object sender, EventArgs e)
        {

            String respuesta = Raya.getInstancia().marcar(1, 1, lblturno.Text[0]);
            if (lblturno.Text == "X")
                pb11.Image = new System.Drawing.Bitmap("C:\\Users\\Estudiante\\programacion-3\\x.png");
            else
                pb11.Image = new System.Drawing.Bitmap("C:\\Users\\Estudiante\\programacion-3\\o.png");
        }

        private void pb12_Click(object sender, EventArgs e)
        {

            String respuesta = Raya.getInstancia().marcar(1, 2, lblturno.Text[0]);
            if (lblturno.Text == "X")
                pb12.Image = new System.Drawing.Bitmap("C:\\Users\\Estudiante\\programacion-3\\x.png");
            else
                pb12.Image = new System.Drawing.Bitmap("C:\\Users\\Estudiante\\programacion-3\\o.png");
        }

        private void pb20_Click(object sender, EventArgs e)
        {

            String respuesta = Raya.getInstancia().marcar(2, 0, lblturno.Text[0]);
            if (lblturno.Text == "X")
                pb20.Image = new System.Drawing.Bitmap("C:\\Users\\Estudiante\\programacion-3\\x.png");
            else
                pb20.Image = new System.Drawing.Bitmap("C:\\Users\\Estudiante\\programacion-3\\o.png");
        }

        private void pb21_Click(object sender, EventArgs e)
        {

            String respuesta = Raya.getInstancia().marcar(2, 1, lblturno.Text[0]);
            if (lblturno.Text == "X")
                pb21.Image = new System.Drawing.Bitmap("C:\\Users\\Estudiante\\programacion-3\\x.png");
            else
                pb21.Image = new System.Drawing.Bitmap("C:\\Users\\Estudiante\\programacion-3\\o.png");
        }
    }
    
}
