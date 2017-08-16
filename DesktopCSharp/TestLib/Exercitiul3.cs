using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    public class Exercitiul3
    {
        public static string hyMessage(string name, bool upper)
        {
            string salut = "Buna ";
            return (upper ? salut.ToUpper() : salut) + (upper ? name.ToUpper() : name) + "!";
        }
    }
}
