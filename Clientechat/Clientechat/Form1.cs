using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;



namespace Clientechat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string StartClient(String cadena)
        {
            string respuesta = "";
            
            byte[] bytes = new byte[1024];

             
            try
            {
               
                
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse("192.168.50.85"), 11000);

                
                Socket sender = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);

                
                try
                {
                    sender.Connect(remoteEP);

                    Console.WriteLine("Socket connectado a {0}",
                        sender.RemoteEndPoint.ToString());

                    

                    byte[] msg = Encoding.ASCII.GetBytes(cadena);

                   
                    int bytesSent = sender.Send(msg);

                      
                    int bytesRec = sender.Receive(bytes);
                    
                        Encoding.ASCII.GetString(bytes, 0, bytesRec);

                    
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                    return respuesta;
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
            return respuesta;
        }
        private void btnenviar_Click(object sender, EventArgs e)
        {
            String mensaje = txtnick + ": " + txtMensaje;
            String mensajerecibido = StartClient(mensaje);
            String[] men = mensajerecibido.Split(':');
            lbConversacion.Items.Add(mensajerecibido);
            if (lbContactos.FindString(men[0]) == -1)
            {

            }
            lbContactos.Items.Add(men[0]);
        }
    }
    
}

