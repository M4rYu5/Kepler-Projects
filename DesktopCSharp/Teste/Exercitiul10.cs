using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    //Write a program that initializes a list integer numbers, and then prints the numbers out along with their sum.

    public class Exercitiul10
    {
        public static void main()
        {
            List<int> lista = new List<int> { 1, 3, 5, 10, 20, 22, 55 };
            Console.WriteLine("Suma urmatoarei liste ");
            foreach(var x in lista)
            {
                Console.Write(x + ", ");
            }
            int suma = 0;
            foreach (var x in lista)
            {
                suma += x;
            }
            Console.WriteLine(" este " + suma);
        }
    }
}
