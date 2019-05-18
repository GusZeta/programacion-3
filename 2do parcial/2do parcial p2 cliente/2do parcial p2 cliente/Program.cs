using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace _2do_parcial_p2_cliente
{
    class Program
    {
        public static void StartClient(int Nro)
        {
            byte[] bytes = new byte[1024];
 
            try
            {
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11000);

                
                Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    sender.Connect(remoteEP);

                    Console.WriteLine("Socket connectado a {0}",
                        sender.RemoteEndPoint.ToString());
                    
                    byte[] intBytes = BitConverter.GetBytes(Nro);

                    int bytesSent = sender.Send(intBytes);

                    int bytesRec = sender.Receive(bytes);
                    Console.WriteLine("El Factorial es = {0}",
                        Encoding.ASCII.GetString(bytes, 0, bytesRec));   
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                    Console.ReadLine();
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
        public static void Main(String[] args)
        {
            Console.WriteLine("Introduzca Un Numero");
            int a = int.Parse(Console.ReadLine());
            StartClient(a);
        }
    }
}
