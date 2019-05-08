using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace servidorchat
{
    class Program
    {
        static List<String> mensajes = new List<String>();
        public static string data = null;

        public static void StartListening()
        {
             
            byte[] bytes = new Byte[1024];

          
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 11000);

         
            Socket listener = new Socket(IPAddress.Any.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);


            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);
  
                while (true)
                {
                    Console.WriteLine("Esperando por ceonexiones ...");
                    
                    Socket handler = listener.Accept();
                    data = null;
                    int bytesRec = handler.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                     
                    

                     
                    Console.WriteLine("Texto recibido: {0}", data);


                    mensajes.Add(data);
                    foreach (String cadena in mensajes)
                    {
                        byte[] msg = Encoding.ASCII.GetBytes(cadena+"-");
                        handler.Send(msg);
                    }
                    
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPresiones ENTER para continuar...");
            Console.Read();

        }

        public static int Main(String[] args)
        {
            StartListening();
            return 0;
        }
    }
}