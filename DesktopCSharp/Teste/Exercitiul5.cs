using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class Exercitiul5
    {
        //Write a program that generates a random number between 1 and 3 and asks the user to guess what the 
        //number is.Tell the user if they guess low, high, or get the correct answer. 
        //Also, tell the user if their answer is outside of the range of numbers that are valid 
        //guesses(less than 1 or more than 3).

        public static void main()
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            int a = rand.Next(3) + 1;

            Console.WriteLine("Introdu un numar intre 1 si 3 (inclusiv)");
            int userInput = int.Parse(Console.ReadLine());

            while(userInput != a)
            {
                if(userInput < 1 && userInput > 3)
                {
                    Console.WriteLine("te rog sa introduci un numar intre 1 si 3 (inclusiv)");
                }
                if (userInput >= 1 && userInput <= 3)
                {
                    Console.WriteLine("esti pe aproape, mai incearca");
                }
                Console.WriteLine("Introdu nou numar ");
                userInput = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Felicitari numarul era {userInput}");
        }
    }
}
