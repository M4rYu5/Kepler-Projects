using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    public class Exercitiul4
    {
        //Write a simple program that defines a variable representing a birth date 
        //and calculates how many days old the person with that birth date is currently.
        

        public static string message(DateTime myBirthDate)
        {
            var today = DateTime.Now;
            return $"Felicitari astazi ai implinit {(today - myBirthDate).Days} zile, iar pana la ziua ta mai ai " + nextBirthDay(myBirthDate) + " zile";
        }

        private static int nextBirthDay(DateTime birthDay)
        {
            var birth = birthDay;
            var i = 0;
            while(DateTime.Now > birth.AddYears(i))
            {
                i++;
            }
            return (birth.AddYears(i) - DateTime.Now).Days;
        }
    }
}
