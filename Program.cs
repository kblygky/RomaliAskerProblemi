using System;

namespace Odev4RomaliAsker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayma sırası giriniz: ");
            int ebeSayisi = Convert.ToInt32(Console.ReadLine());

            int kalanKisi = sayi;//Sayıyı kalan kişiye eşitlemekte amaç 2 değer kalana kadar her do while döngüsünde 1 azaltarak 2 kalınca döngüden çıkarmak
            int[] dizi = new int[sayi];


            for (int i = 0; i < sayi; i++)
                dizi[i] = i+1;//oyuncu listesi

            int a = ebeSayisi - 1;//-1 olmasının nedeni a yı dizilerde kullanacağımız için ve diziler 0dan başladığı için

            do
            {
                
                dizi[a] = 0;//a. sıradakini öldür
                int sayac = 0;
                for (int i = a + 1; i <= a + ebeSayisi + sayac; i++)
                {//son ölenden sonra ebesayısı kadar kişi atlanıyor cevap değişkeni bi sonraki ölücekle son ölen arasında kaç ölü olduğunu hesaplıyor
                    int cevap = i;

                    if (cevap > sayi - 1)
                    {
                        cevap = (cevap % sayi); //dizinin sonuna gelindiğinde başa döndürülüyor
                    }
                    if (dizi[cevap] == 0)//kaç ölü olduğunu sayaca ekleniyor
                        sayac++;
                }

                a += ebeSayisi + sayac; //bi sonraki ölücek kişi

                if (a > sayi - 1)
                {
                    a = (a % sayi);//eğer değer diziden büyükse dizinin başına dönülüyor
                }

                kalanKisi--;//baştaki adıma eşit olan sayac 1 azaltılıyor ve 2 olana kadar döngü devam ediyor
            } while (kalanKisi != 2);

            for (int i = 0; i < sayi; i++)//son kalan kişiler
            {
                if (dizi[i] != 0) Console.WriteLine("sona kalan:" + dizi[i].ToString());
            }
        }
    }
}
