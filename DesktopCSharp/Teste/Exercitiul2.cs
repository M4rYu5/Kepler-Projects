using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class Exercitiul2 : TestLib.Exercitiul2
    {
        //Create another variable to represent the greeting.

        public static void main()
        {
            var name = "Marius"; // use your name here
            Console.WriteLine(hyMessage(name));
        }
    }
}
