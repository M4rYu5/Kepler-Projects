using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class Exercitiul4 : TestLib.Exercitiul4
    {
        //Write a simple program that defines a variable representing a birth date 
        //and calculates how many days old the person with that birth date is currently.

        public static void main()
        {
            Console.WriteLine(message(new DateTime(1994, 9, 11)));
        }
        
    }
}
