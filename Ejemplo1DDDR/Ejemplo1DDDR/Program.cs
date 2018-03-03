using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1DDDR
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta c1 = new Cuenta("Casa");

            Cuenta c2 = new Cuenta("Victor",300);

            //ingresar dinero en las cunetas
            c1.ingresar(500);
            c2.ingresar(600);

            Console.WriteLine(c1);



        }



    }
}
