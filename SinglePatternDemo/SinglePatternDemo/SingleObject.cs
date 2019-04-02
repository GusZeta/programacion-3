using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePatternDemo
{
    class SingleObject
    {
        private static SingleObject instace = null;

        private SingleObject()
        {

        }
        public static SingleObject getInstance()
        {
            if (instace == null)
                return new SingleObject();
            else
                return instace;
        }
        public void ShowMethod()
        {
            Console.WriteLine("soy singleton");
        }
    }
}
