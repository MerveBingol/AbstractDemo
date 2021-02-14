using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo
{
    class Tezgahtar : Calisan
    {
        private int Satis;
        public void SetSatis(int satis) { 
            this.Satis = satis;
        
        }
        public override string kimimBen()
        {
            return "Tezgahtar"; 
        }

        public override int MaasHesapla()
        {
            return this.Satis / 10;
        }
    }
}
