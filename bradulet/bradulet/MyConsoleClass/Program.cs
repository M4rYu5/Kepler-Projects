using System;

namespace BraduletConsole.MyConsoleClass
{
    
    class Program
    {
        

        static void afisareMatrice(int linii, int coloane, byte[,] matrice)
        {
            for (int i = 0; i < linii; i++)
            {
                for (int j = 0; j < coloane; j++)
                {
                    Console.Write(matrice[i, j]);
                }
                Console.Write("\n");
            }
        }


        static void Main(string[] args)
        {
            
            Console.WriteLine("Intordu numarul de ramuri ");
            int numarRamuri = Convert.ToInt16(Console.ReadLine());

            BradConsole brad = new BradConsole(numarRamuri);

            byte[,] matrix = brad.makeMatrix();



            brad.afisare();
            Program.afisareMatrice(brad.getLiniiBrad(), brad.getColoaneBrad(), matrix);

            Console.ReadLine();
        }
        


    }
}

