using System;

namespace ServidorAsincrono
{
using System;  
using System.Net;  
using System.Net.Sockets;  
using System.Text;  
using System.Threading;  
  
// Objeto Estado para leer los datos del cliente asincronamente 
public class StateObject
    {
        // socket del Client  .  
        public Socket workSocket = null;
        // Tamaño del buffer para recibir Size of receive buffer.  
        public const int BufferSize = 1024;
        // buffe reicibido .  
        public byte[] buffer = new byte[BufferSize];
        // datos string recibidos.  
        public StringBuilder sb = new StringBuilder();
    }

    public class AsynchronousSocketListener
    {
        // Señal de hilo .  
        public static ManualResetEvent allDone = new ManualResetEvent(false);

        public AsynchronousSocketListener()
        {
        }

        public static void StartListening()
        {
            // Establecer el punto final deacceso al socket .  
            // E nombre DNS de la computador
            // corriendo y escuchando es "host.contoso.com".  
 //           IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
   //         IPAddress ipAddress = ipHostInfo.AddressList[0];
//            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 11000);

            
            // Crear el socket TCP/IP .  
            Socket listener = new Socket(IPAddress.Any.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            // Nombrar el socket en el puntodeentrada final y escuchar conexiones entrantes.  
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(100);

                while (true)
                {
                    // colocar el evento al estado sin señal.  
                    allDone.Reset();

                    // iniciar el socket asincrono paraescuchar las conexiones .  
                    Console.WriteLine("Esperando por conexiones ...");
                    listener.BeginAccept(
                        new AsyncCallback(AcceptCallback),
                        listener);

                    // esperar hasta que  la conexion sea hecha antes de continuar .  
                    allDone.WaitOne();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\n Presiones INTRO para continuar...");
            Console.Read();

        }

        public static void AcceptCallback(IAsyncResult ar)
        {
            // Señal en el hulo principal para continuar .  
            allDone.Set();

            // obtenet el socket cuyo hilo en el cliente es requerido.  
            Socket listener = (Socket)ar.AsyncState;
            Socket handler = listener.EndAccept(ar);

            // Crear el objeto estado.  
            StateObject state = new StateObject();
            state.workSocket = handler;
            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                new AsyncCallback(ReadCallback), state);
        }

        public static void ReadCallback(IAsyncResult ar)
        {
            String content = String.Empty;

            // REcuperar el estado del objeto y del manejador del socket
            // desde el objeto de estado asincrono.  
            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;

            // Leer datos desde elsocket cliente.   
            int bytesRead = handler.EndReceive(ar);

            if (bytesRead > 0)
            {
                // Podría haber más datos, asi que almacena los datos recibidos .  
                state.sb.Append(Encoding.ASCII.GetString(
                    state.buffer, 0, bytesRead));

                // verifica el tag fin de arhivo . si este no esta ahi lee
                // mas datos.  
                content = state.sb.ToString();
                if (content.IndexOf("<EOF>") > -1)
                {
                    // todos los datos han sido leidos desde el    
                    // cliente muestra en laocnsola .  
                    Console.WriteLine("Leido {0} bytes desde el socket. \n Dato : {1}",
                        content.Length, content);
                    // imprimir el dato deregreso al cliente.  
                    Send(handler, content);
                }
                else
                {
                    // No todo los los datos recibidos obtener mas .  
                    handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReadCallback), state);
                }
            }
        }

        private static void Send(Socket handler, String data)
        {
            // Convertir los datos string a datos  byte usando codificacion ASCII.  
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            // Empezar enviandolos datos al dispositivo remoto .  
            handler.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), handler);
        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Recuperar el socket del objeto de estado.  
                Socket handler = (Socket)ar.AsyncState;

                // Completar enviado los datos de  el dispositivo remoto .  
                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("Enviado {0} bytes al  cliente.", bytesSent);

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static int Main(String[] args)
        {
            StartListening();
            return 0;
        }

    }
}

