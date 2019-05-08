using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TresEnRayaCliente
{
    public partial class Form1 : Form
    {
        string marca = "";
        const String rutax = "C:\\Users\\Estudiante\\programacion-3\\x.png";
        const String rutaO = "C:\\Users\\Estudiante\\programacion-3\\o.png";
        String Solicitud = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void Renderizar(String mensaje)
        {
            
            String[] filas = mensaje.Split(':');
            String[] fila1= filas[0].Split(',');
            String[] fila2 = filas[1].Split(',');
            String[] fila3 = filas[2].Split(',');
            
            if (fila1[0][0]=='x')
                    pb00.Image = new System.Drawing.Bitmap(rutax);
            if (fila1[0][0] == 'O')
                pb00.Image = new System.Drawing.Bitmap(rutaO);

            if (fila1[1][0] == 'x')
                pb01.Image = new System.Drawing.Bitmap(rutax);
            if (fila1[1][0] == 'O')
                pb01.Image = new System.Drawing.Bitmap(rutaO);

            if (fila1[2][0] == 'x')
                pb02.Image = new System.Drawing.Bitmap(rutax);
            if (fila1[2][0] == 'O')
                pb02.Image = new System.Drawing.Bitmap(rutaO);

            if (fila2[0][0] == 'x')
                pb10.Image = new System.Drawing.Bitmap(rutax);
            if (fila2[0][0] == 'O')
                pb10.Image = new System.Drawing.Bitmap(rutaO);

            if (fila2[1][0] == 'x')
                pb11.Image = new System.Drawing.Bitmap(rutax);
            if (fila2[1][0] == 'O')
                pb11.Image = new System.Drawing.Bitmap(rutaO);

            if (fila2[2][0] == 'x')
                pb12.Image = new System.Drawing.Bitmap(rutax);
            if (fila2[2][0] == 'O')
                pb12.Image = new System.Drawing.Bitmap(rutaO);


            if (fila3[0][0] == 'x')
                pb20.Image = new System.Drawing.Bitmap(rutax);
            if (fila3[0][0] == 'O')
                pb20.Image = new System.Drawing.Bitmap(rutaO);

            if (fila3[1][0] == 'x')
                pb21.Image = new System.Drawing.Bitmap(rutax);
            if (fila3[1][0] == 'O')
                pb21.Image = new System.Drawing.Bitmap(rutaO);

            if (fila3[2][0] == 'x')
                pb22.Image = new System.Drawing.Bitmap(rutax);
            if (fila3[2][0] == 'O')
                pb22.Image = new System.Drawing.Bitmap(rutaO);

        }
        public void AnalizaMensage(String mensaje)
        {
            String[] respuesta = mensaje.Split(':');
            switch (respuesta[0])
            {
                case "ganador":
                    lblMensaje.Text = "el ganador es: " + respuesta[1];
                    break;
                case "continuar":
                    if (lblTurno.Text == "x")
                        lblTurno.Text = "o";
                    else
                        lblTurno.Text = "x";
                    break;
                case "error":
                    lblMensaje.Text = "error: " + respuesta[1];
                    break;
                case "resultado":
                    lblMensaje.Text = "ha habido un empate";

                    break;

            }
        }

        private void rbx_CheckedChanged(object sender, EventArgs e)
        {
            rbO.Enabled = false;
            rbx.Enabled = false;
            marca = "x";
        }

        private void rbO_CheckedChanged(object sender, EventArgs e)
        {
            rbO.Enabled = false;
            rbx.Enabled = false;
            marca = "O";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rbO.Enabled = true;
            rbx.Enabled = true;
        }

        private void pb00_Click(object sender, EventArgs e)
        {
            Solicitud = "0,0,"+marca;
            String Respuesta= EnviarMensaje(Solicitud);
            AnalizaMensage(Respuesta);
            String Marcaciones = EnviarMensaje("getMarcas");

            Renderizar(Marcaciones);
           
        }
        private String EnviarMensaje(String Mensaje)
        {
            byte[] bytes = new byte[1024];
            try
            {
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11000);
                // Crear un socket TCP/IP  .  
                Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    // de conecta al servidor
                    sender.Connect(remoteEP);
                    Console.WriteLine("Socket connectado a {0}",
                        sender.RemoteEndPoint.ToString());
                    byte[] msg = Encoding.ASCII.GetBytes(Mensaje);
                    // aqui se manda el mensaje
                    int bytesSent = sender.Send(msg);
                    // Recibe ladespuesta desde el dispositivo remoto .  
                    
                    int bytesRec = sender.Receive(bytes);

                    
                    String Respuesta = Encoding.ASCII.GetString(bytes, 0, bytesRec);
 

                    return Respuesta; 
                    // libera el socket.  
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error no manejado  : {0}", e.ToString());
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return null;

        }
        //"192.168.50.84"
        private void pb01_Click(object sender, EventArgs e)
        {
            Solicitud = "0,1," + marca;
            String Respuesta = EnviarMensaje(Solicitud);
            AnalizaMensage(Respuesta);
            Renderizar(EnviarMensaje("getMarcas"));

        }

        private void pb02_Click(object sender, EventArgs e)
        {
            Solicitud = "0,2," + marca;
            String Respuesta = EnviarMensaje(Solicitud);
            AnalizaMensage(Respuesta);
            Renderizar(EnviarMensaje("getMarcas"));

        }

        private void pb10_Click(object sender, EventArgs e)
        {
            Solicitud = "1,0," + marca;
            String Respuesta = EnviarMensaje(Solicitud);
            AnalizaMensage(Respuesta);
            Renderizar(EnviarMensaje("getMarcas"));

        }

        private void pb11_Click(object sender, EventArgs e)
        {
            Solicitud = "1,1," + marca;
            String Respuesta = EnviarMensaje(Solicitud);
            AnalizaMensage(Respuesta);
            Renderizar(EnviarMensaje("getMarcas"));

        }

        private void pb12_Click(object sender, EventArgs e)
        {
            Solicitud = "1,2," + marca;
            String Respuesta = EnviarMensaje(Solicitud);
            AnalizaMensage(Respuesta);
            Renderizar(EnviarMensaje("getMarcas"));

        }

        private void pb20_Click(object sender, EventArgs e)
        {
            Solicitud = "2,0," + marca;
            String Respuesta = EnviarMensaje(Solicitud);
            AnalizaMensage(Respuesta);
            Renderizar(EnviarMensaje("getMarcas"));

        }

        private void pb21_Click(object sender, EventArgs e)
        {
            Solicitud = "2,1," + marca;
            String Respuesta = EnviarMensaje(Solicitud);
            AnalizaMensage(Respuesta);
            Renderizar(EnviarMensaje("getMarcas"));

        }

        private void pb22_Click(object sender, EventArgs e)
        {
            Solicitud = "2,2," + marca;
            String Respuesta = EnviarMensaje(Solicitud);
            AnalizaMensage(Respuesta);
            Renderizar(EnviarMensaje("getMarcas"));

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String Respuesta = EnviarMensaje("Reiniciar");


        }
    }
}
