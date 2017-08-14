using System;
using System.Collections.Generic;
using System.Text;

namespace BraduletConsole.MyConsoleClass
{
    public class BradConsole : BraduletAP.Brad
    {
        public BradConsole(int ramuri) : base(ramuri) { }

        private void afisareRamura(int from, int linii)
        {             int numarStelute = 1;
            while (numarStelute <= linii)
            {
                for (int j = 0; j < from + (linii - numarStelute) / 2; j++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < numarStelute; i++)
                {
                    Console.Write("*");
                }
                numarStelute = numarStelute + 2;
                Console.Write("\n");
            }
        }

        public override string afisare()
        {
            int numarSteluteDePeUltimulRand = base.numarRamuri * 2 + 1;

            //todo poate incep cu i de la 1?
            for (int i = 1; i < numarSteluteDePeUltimulRand; i = i + 2)
            {
                afisareRamura((numarSteluteDePeUltimulRand - i )/ 2 - 1, i + 2);
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < numarRamuri; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*\n");
            }

            return "";
        }

    }
}
