using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckFacade cliente1 = new CheckFacade();
            cliente1.buscar("02/07/2018", "08/07/2018", "Lima", "Cancún");

            CheckFacade cliente2 = new CheckFacade();
            cliente2.buscar("02/07/2018", "08/07/2018", "Lima", "Quito");
            Console.ReadLine();
        }
    }
}
