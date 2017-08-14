using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BraduletWEB
{
    public class BradWeb : BraduletAP.Brad
    {
        public BradWeb(int ramuri) : base(ramuri)
        {

        }

        private string afisareRamura(int from, int linii)
        {
            string s = "";
            int numarStelute = 1;
            while (numarStelute <= linii)
            {
                for (int j = 0; j < from + (linii - numarStelute) / 2; j++)
                {
                    s = s + " ";
                }
                for (int i = 0; i < numarStelute; i++)
                {
                    s = s + "*";
                }
                numarStelute = numarStelute + 2;
                s = s + "\n";
            }
            return s;
        }

        public override string afisare()
        {
            string s = "";

        int numarSteluteDePeUltimulRand = base.numarRamuri * 2 + 1;

            //todo poate incep cu i de la 1?
            for (int i = 1; i<numarSteluteDePeUltimulRand; i = i + 2)
            {
                s = s + afisareRamura((numarSteluteDePeUltimulRand - i) / 2 - 1, i + 2);
    }

            for (int i = 0; i< 2; i++)
            {
                for (int j = 0; j<numarRamuri; j++)
                {
                    s = s + " ";
                }
                s = s + "*\n";
            }

            return s;
        }

        public override string ToString()
        {
            return afisare();
        }
    }
}