using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{

    public class Exercitiul6
    {
        //Write a program that greets the user using the appropriate greeting for the time of day.Use only if, not else or switch, statements to do 
        //so.Be sure to include the following greetings:
            //"Good Morning"
            //"Good Afternoon"
            //"Good Evening"
            //"Good Night"

        public static void main()
        {
            if(DateTime.Now.Hour > 22)
            {
                Console.WriteLine("Good Night");
            }
            if(DateTime.Now.Hour > 18 && DateTime.Now.Hour <= 22)
            {
                Console.WriteLine("Good Evening");
            }
            if (DateTime.Now.Hour > 12 && DateTime.Now.Hour <= 18)
            {
                Console.WriteLine("Good Afternoon");
            }
            if (DateTime.Now.Hour > 0 && DateTime.Now.Hour <= 12)
            {
                Console.WriteLine("Good Morning");
            }
        }
    }
}
