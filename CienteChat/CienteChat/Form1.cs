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

namespace CienteChat
{
    public partial class frmChat : Form
    {
        static String Respuesta = "";

        public frmChat()
        {
            InitializeComponent();
        }
        public void StartClient(String cadena)
        {
             byte[] bytes = new byte[1024];
            try
            {
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(txtIP.Text), 11000);
                // Crear un socket TCP/IP  .  
                Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    // de conecta al servidor
                    sender.Connect(remoteEP);
                    Console.WriteLine("Socket connectado a {0}",
                        sender.RemoteEndPoint.ToString());
                    byte[] msg = Encoding.ASCII.GetBytes(cadena);
                    // aqui se manda el mensaje
                    int bytesSent = sender.Send(msg);
                    // Recibe ladespuesta desde el dispositivo remoto .  
                    int bytesRec = sender.Receive(bytes);
                    while (bytesRec > 0)
                        {
                        Respuesta += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        bytesRec = sender.Receive(bytes);

                    }
                    String[] resp=Respuesta.Split('-');

                    lbConversacion.Items.Clear();

                    foreach (string r in resp)
                    {
                        lbConversacion.Items.Add(r);
                        String[] men = r.Split(':');
                        // buscar si ya existe el nick
                        if (lbParticipantes.FindString(men[0]) == -1)
                            lbParticipantes.Items.Add(men[0]);
                    }

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
            
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {   
            String mensaje = txtNick.Text + ":" + txtMensaje.Text;
            StartClient(mensaje);
            
            

        }
    }
}
