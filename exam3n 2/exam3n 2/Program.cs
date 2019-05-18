using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab_Estruct_Selectiva
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int n;

                Console.Clear();  //Limpia la pantalla

                //Entrada
                Console.WriteLine("1. Sueldo por hrs. extras de un trabajador");
                Console.WriteLine("2. Asignación de letras a notas de un alumno");
                Console.WriteLine("3. Calculo de comisión de un vendedor ");
                Console.WriteLine("4. Determina si una letra es vocal o consonante ");
                Console.WriteLine("5. Platos de comida");
                Console.WriteLine("6. Tipo de triángulo");
                Console.WriteLine("7. Lanzamiento de tres dados");
                Console.WriteLine("8. El mayor de tres numeros");
                Console.WriteLine("9. Tres lados conforman un triángulo ? ");
                Console.WriteLine("10. Devuelve la estación del año");
                Console.WriteLine("");

                Console.Write("Digite un valor entre 1-10: ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                //Proceso
                switch (n)
                {
                    case 1:
                        uno();
                        break;
                    case 2:
                        dos();
                        break;
                    case 3:
                        tres();
                        break;
                    case 4:
                        //cuatro();
                        break;
                    case 5:
                        // cinco();
                        break;
                    case 6:
                        //seis();
                        break;
                    case 7:
                        //siete();
                        break;
                    case 8:
                        //ocho();
                        break;
                    case 9:
                        // nueve();
                        break;
                    case 10:
                        //diez();
                        break;
                    default:
                        Console.WriteLine("Introduzca un valor entre 1 y 10");
                        break;
                }
                Console.WriteLine("");
                Console.Write("Digite (Intro) para continuar, (Esc) para salir ...");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);












        }



        static void uno()
        {

            string[] N = new string[5];
            int[] E = new int[5];

            //proceso de calculo

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("introduzca los nobmres");
                N[i] = Console.ReadLine();

                Console.WriteLine("intoduzca las edades");
                E[i] = int.Parse(Console.ReadLine());

            }


            for (int i = 0; i <= 4; i++)
            {
                if (E[i] > 18)
                    Console.WriteLine(N[i] + " " + E[i]);

            }

        }

        static void dos()
        {


            int n = 1, d = 0, s = 0;
            int a = 0, b = 0;
            int M = 0;

            Console.WriteLine("cantidad de numeros primos: ");
            M = int.Parse(Console.ReadLine());



            while (s < M)
            {
                d = 2; b = 0;


                while ((d < n) && (b == 0))
                {



                    a = n % d;

                    if (a == 0)
                    {
                        b = 1;
                    }
                    else
                    {
                        d = d + 1;
                    }
                }



                if (b == 0)
                {
                    Console.Write(n + " ");
                    s = s + 1;
                }

                n = n + 1;
            }




        }

        static void tres()
        {



            Random rnd = new Random();
            int n, l;
            Console.WriteLine("introduzca las filas de la matriz");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("introduzca las filas de la matriz");
            l = int.Parse(Console.ReadLine());


            int[] v = new int[n];
            int[,] M = new int[n, l];


            //proceso de calculo

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < l; k++)

                {
                    M[i, k] = rnd.Next(1, 50);


                }

                Console.WriteLine("");
            }


            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < l; k++)

                {
                    Console.Write(M[i, k]);


                }

                Console.WriteLine("");

            }

            Console.WriteLine("");
           

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < l; k++)

                {

                    v[i] = M[i, 0];



              

                }      

            }
            Array.Sort(v);

            Console.WriteLine("");




            Console.WriteLine("los nuemro ordenados son" + v[i]);


       


        }
    }

}
