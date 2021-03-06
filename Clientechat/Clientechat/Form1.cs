﻿using System;
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
        String respuesta = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void StartClient(String cadena)
        {
            
           
            
            byte[] bytes = new byte[1024];

             
            try
            {
               
                
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse("192.168.50.84"), 11000);

                
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
                    while (bytesRec > 0)
                    {
                        
                        respuesta = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        
                        bytesRec = sender.Receive(bytes);
                        
                    }

                    String[] resp = respuesta.Split('-');
                    lbConversacion.Items.Clear();
                    foreach (string r in resp)
                    {
                        lbConversacion.Items.Add(r);
                        String[] men = r.Split(':');
                        if (lbContactos.FindString(men[0]) == -1)
                        {
                            lbContactos.Items.Add(men[0]);
                        }
                    }

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
        private void btnenviar_Click(object sender, EventArgs e)
        {
            String mensaje = txtnick.Text + ": " + txtMensaje.Text;


            StartClient(mensaje);
        }
    }
    
}

