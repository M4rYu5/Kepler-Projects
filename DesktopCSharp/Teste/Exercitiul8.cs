using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class Exercitiul8
    {
        //Write a program that prints the result of counting up to 24 using four different 
        //increments.First, count by 1s, then by 2s, by 3s, and finally by 4s.

        public static void main()
        {
            for(int i = 1; i < 5; i++)
            {
                int num = 0;
                while(num <= 24)
                {
                    Console.Write(num + ", ");
                    num += i;
                }
                Console.WriteLine();
            }
        }
    }
}
