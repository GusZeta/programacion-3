using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OberverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            new SolObservador(subject);
            new PesoARGObservador(subject);
            new PesoMXObservador(subject);
            new PesoBOLObservador(subject);
            Console.WriteLine("Si desea cambiar 10 dólares obtendrá : ");
            subject.setEstado(10);
            Console.WriteLine("-----------------");
            Console.WriteLine("Si desea cambiar 100 dólares obtendrá : ");
            subject.setEstado(100);
            Console.ReadLine();
        }
    }
}
