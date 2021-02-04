using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo
{
   public abstract class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public abstract int MaasHesapla();
       
        public string getBilgi() {

            return kimimBen() + ":" + Ad + "" + Soyad + "" + " bu ay" + MaasHesapla() + " TL alacaktır.";
        
        }
        public abstract string kimimBen();




    }
}
