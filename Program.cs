using System;

namespace AbstractDemo
{
    class Program
    {
        /* Bir giyim mağazasında çalışan kişilerin maaşlarını ekrana yazdıran bir program yazacağız.
        Çalışanların maaşları, görevlerine göre farklı şekillerde hesaplanıyor. 
        Müdür: Aylık 2000 Tl maaş + prim ile çalışıyor.Prim ise toplam satış tutarına göre hesaplanıyor.
        O ayki tutarın 20.000 TL yi geçmesi durumunda ,20.000 TL den fazla olan miktarın % 10 u kadar prim alıyor.
        
        Tezgahtar: Prim ile çalışıyor. Yaptığı aylık toplam satışın %10 u kadar prim alıyor.
        
        idari Personel: Aylık 800 TL sabit maaş ile çalışıyor.

        Mağazada 1 müdür, 2 tezgahtar,2 idari personel çalışıyor.Ay sonunda kimin ne kadar 
        satış yaptığı ya da kaç saat çalıştığı sisteme girilecek ve herkesin alması gereken maaş,
        kişinin yaptığı iş adı ve soyadı ekrana  yazdırılacaktır.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------Müdür -----------------------------------\n");
            Calisan mudur = new Mudur();
            mudur.Ad = "Merve";
            mudur.Soyad = "BİNGÖL";
            mudur.kimimBen();
            mudur.MaasHesapla();
            
            Console.WriteLine(mudur.kimimBen()+"\n" + "Ad : "+ mudur.Ad+ "\n"+"Soyad : " + mudur.Soyad+ "\n"+
                "Maaşı : " + mudur.MaasHesapla() + " TL");

            Console.WriteLine("\n---------------------Tezgahtar1---------------------------------\n");

            Calisan tezgahtar1 = new Tezgahtar();
            tezgahtar1.Ad = "Ayşe";
            tezgahtar1.Soyad = "BİLİR";
            tezgahtar1.kimimBen();
            tezgahtar1.MaasHesapla();
            ((Tezgahtar)tezgahtar1).SetSatis(25000); // Boxing
            Console.WriteLine(tezgahtar1.kimimBen() +"\n" + "Ad : " + tezgahtar1.Ad +"\n"+ "Soyad : " + tezgahtar1.Soyad + "\n"+
                "Maaşı : " + tezgahtar1.MaasHesapla() + " TL");

            Console.WriteLine("\n----------------------Tezgahtar2--------------------------------\n");
            Calisan tezgahtar2 = new Tezgahtar();
            tezgahtar2.Ad = "Ali";
            tezgahtar2.Soyad = "OKUR";
            tezgahtar2.kimimBen();
            tezgahtar2.MaasHesapla();
            ((Tezgahtar)tezgahtar2).SetSatis(30000); // Boxing
            Console.WriteLine(tezgahtar2.kimimBen()+ "\n" + "Ad : " + tezgahtar2.Ad +"\n" + "Soyad : " + tezgahtar2.Soyad + "\n"+
                "Maaşı : " + tezgahtar2.MaasHesapla() + " TL");


            Console.WriteLine("\n----------------------İdari Personel 1--------------------------------\n");

            Calisan idariPersonel = new IdariPersonel();
            idariPersonel.Ad = "Meryem";
            idariPersonel.Soyad = "KAYAR";
            idariPersonel.kimimBen();
            idariPersonel.MaasHesapla();
   
            Console.WriteLine(idariPersonel.kimimBen()+"\n" + "Ad : " + idariPersonel.Ad+ "\n" + "Soyad : " + idariPersonel.Soyad + "\n"+
                "Maaşı : " + idariPersonel.MaasHesapla() + " TL");

            Console.WriteLine("\n----------------------İdari Personel 2--------------------------------\n");
            Calisan idariPersone2 = new IdariPersonel();
            idariPersone2.Ad = "Kemal";
            idariPersone2.Soyad = "BEY";
            idariPersone2.kimimBen();
            idariPersone2.MaasHesapla();

            Console.WriteLine(idariPersonel.kimimBen()+"\n" + "Ad : " + idariPersonel.Ad +"\n" + "Soyad : " + idariPersonel.Soyad + "\n"+
                "Maaşı : " + idariPersonel.MaasHesapla()+ " TL");
        }
    }
}
