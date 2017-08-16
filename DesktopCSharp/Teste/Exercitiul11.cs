using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class Exercitiul11
    {
        //In lesson 10 you wrote a program to manage a list of items, responding to different commands 
        //the user typed.Use what you've learned about methods to break up that program into several methods, 
        //each responsible for a different part of the program.
        static List<string> lista = new List<string>();

        public static void main()
        {

            writeCommands();
            while (true)
            {
                Console.WriteLine(String.Join(",", lista));
                Console.Write("optiunea ta este:  ");
                int userOpt = int.Parse(Console.ReadLine());
                switch (userOpt)
                {
                    case 1:
                        //adauga
                        adauga();
                        break;
                    case 2:
                        //sterge
                        sterge();
                        break;
                    case 3:
                        //sterge tot
                        stergeTot();
                        break;
                    case 4:
                        return;
                }
            }
        }
        private static void writeCommands()
        {
            Console.WriteLine(
@"Apasa: 
1. pentru a adauga in lista, 
2. pentru a sterge din lista, 
3. pentru a sterge toata lista
4. pentru a iesi din loop");
        }
        private static void adauga()
        {
            Console.Write("Introdu ce vrei sa adaugi in lista  ");
            lista.Add(Console.ReadLine());
        }
        private static void sterge()
        {
            Console.Write("Introdu pozitia de pe care vrei sa o stergi  ");
            int poz = int.Parse(Console.ReadLine());
            if (lista.Count > poz)
            {
                lista.RemoveAt(poz);
            }
            else
            {
                Console.Write("Nu exista (indexul incepe de la 0)");
            }
        }
        private static void stergeTot()
        {
            Console.Write("Lista stearsa!");
            lista.Clear();
        }
    }
}
