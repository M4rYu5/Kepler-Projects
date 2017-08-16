using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class Exercitiul9
    {

        //Write a simple program that lets the user manage a list of elements.It can be a grocery list, "to do" list, etc.
        //Refer to Looping Based on a Logical Expression if necessary to see how to implement an infinite loop.Each time through the loop, 
        //ask the user to perform an operation, and then show the current contents of their list.The operations available should be Add, Remove, and Clear.

        public static void main()
        {
            List<string> lista = new List<string>();

                Console.WriteLine(
@"Apasa: 
1. pentru a adauga in lista, 
2. pentru a sterge din lista, 
3. pentru a sterge toata lista
4. pentru a iesi din loop");
            while (true)
            {
                Console.WriteLine(String.Join(",", lista));
                Console.Write("optiunea ta este:  ");
                int userOpt = int.Parse(Console.ReadLine());
                switch (userOpt)
                {
                    case 1:
                        //adauga
                        Console.Write("Introdu ce vrei sa adaugi in lista  ");
                        lista.Add(Console.ReadLine());
                        break;
                    case 2:
                        //sterge
                        Console.Write("Introdu pozitia de pe care vrei sa o stergi  ");
                        int poz = int.Parse(Console.ReadLine());
                        if (lista.Count > poz) {
                            lista.RemoveAt(poz);
                        }
                        else
                        {
                            Console.Write("Nu exista (indexul incepe de la 0)");
                        }
                        break;
                    case 3:
                        //sterge tot
                        Console.Write("Lista stearsa!");
                        lista.Clear();
                        break;
                    case 4:
                        return;
                }
            }
        }
    }
}
