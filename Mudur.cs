using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo
{
     public class Mudur : Calisan
    {
       public  int Maas = 2000;
       public int PrimLimit = 20000;
        private int Satis = 37000;

        public override int MaasHesapla()
        {
            if (Satis > PrimLimit)
            {
                return Maas + (Satis - PrimLimit) / 10;

            }
            else
                return Maas;
        }

        public override string kimimBen()
        {
            return "Müdür";
        }
    }

}

