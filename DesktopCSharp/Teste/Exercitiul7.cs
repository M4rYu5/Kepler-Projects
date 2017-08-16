using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class Exercitiul7
    {
        //The following program uses an if statement to determine whether a given number is divisible by 2. Modify
        //the program to change the two outer if statements into while loops so that the program lists all of the factors 
        //of the number the user supplies.You will need to ensure you
        //update the values of both the number and factor variables within the loop(s) to avoid an infinite loop condition.

        public static void main()
        {
            Console.WriteLine("Enter a number >= 2:");
            int number = int.Parse(Console.ReadLine());
            if(number < 2)
            {
                Console.WriteLine("numarul este mai mic decat 2");
                return;
            }
            Console.Write("Factors: ");
            while (number > 1)
            {
                int candidateFactor = 2;
                while (candidateFactor <= number)
                {
                    if (number % candidateFactor == 0)
                    {
                        Console.Write(candidateFactor);
                        number = number / candidateFactor;
                        if(number > 1)
                        {
                            Console.Write(", ");
                        }
                    }
                    candidateFactor++;
                }
            }
            Console.WriteLine();
        }
    }
}
