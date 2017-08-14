using System;

namespace BraduletAP
{
    public abstract class Brad
    {

        //todo creaza o matrice pentru puncte

        protected int numarRamuri;



        public Brad(int numarRamuri)
        {
            this.numarRamuri = numarRamuri;
        }

        public void setNumarRamuri(int ramuri)
        {
            numarRamuri = ramuri;
        }

        public int getNumarRamuri()
        {
            return numarRamuri;
        }


        public int getLiniiBrad()
        {
            int numarLinii = 2;
            for (int i = 0; i < numarRamuri; i++)
            {
                numarLinii = numarLinii + i + 2;
            }
            return numarLinii;
        }

        public int getColoaneBrad()
        {
            return numarRamuri * 2 + 1;
        }

        

        public abstract string afisare();

        public byte[,] makeMatrix()
        {
            int linii = getLiniiBrad();
            int coloane = getColoaneBrad();

            byte[,] matrix = new byte[linii, coloane];

            //init matrice

            int numarulStelutelor = 0;
            int numarSteluteRamura = 2;
            int countStelute = 0;
            for (int i = 0; i < linii; i++)
            {
                numarulStelutelor++;
                countStelute++;
                if (countStelute > numarSteluteRamura)
                {
                    numarSteluteRamura++;
                    countStelute = 1;
                }
                for (int j = 0; j < coloane; j++)
                {
                    if ((j > (numarRamuri - countStelute)) && (j < numarRamuri + countStelute) && i < linii - 2)
                    {
                        matrix[i, j] = 1;
                        continue;
                    }
                    matrix[i, j] = 0;
                }
            }

            matrix[linii - 2, numarRamuri] = 1;
            matrix[linii - 1, numarRamuri] = 1;

            return matrix;
        }
    }
}
