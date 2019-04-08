using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta(1, 200);

            DepositarImp opDepositar = new DepositarImp(cuenta, 100);
            RetirarImp opRetirar = new RetirarImp(cuenta, 50);
            RetirarImp opRetirar2 = new RetirarImp(cuenta, 10);
            MostrarImp opMostrar = new MostrarImp(cuenta);
            Invoker ivk = new Invoker();

            ivk.recibirOperacion(opDepositar);
            ivk.recibirOperacion(opRetirar);
            ivk.recibirOperacion(opRetirar2);
            ivk.recibirOperacion(opMostrar);

            ivk.realizarOperaciones();

            Console.ReadKey();

        }
    }
}