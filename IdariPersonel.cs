using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo
{
    class IdariPersonel : Calisan
    {
        public int IdariPersonelMaas = 800;
        public override string kimimBen()
        {
            return "İdari Personel";
        }

        public override int MaasHesapla()
        {
            return IdariPersonelMaas;
        }
    }
}
