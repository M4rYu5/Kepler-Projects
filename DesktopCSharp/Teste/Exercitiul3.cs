using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class Exercitiul3 : TestLib.Exercitiul3
    {
        public static void main()
        {
            //Now it's your turn. Create some code that will take two string 
            //variables and build a greeting from them. One variable should be the greeting and another 
            //variable should be the name to be greeted. Make sure your greeting includes punctuation at the end, 
            //after the position where the name will be inserted!

            //For a little extra credit, support an optional third variable that can be set to either 'loud' or 'quiet'.
            //When loud, change whatever the greeting is to all UPPERCASE.If quiet, change it to all lowercase. 
            //If the third variable is null or empty, the greeting should remain unchanged.

            bool upper = true;
            
            string name = "Marius";
            Console.WriteLine(hyMessage(name, true));
        }
       
    }
}
