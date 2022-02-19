using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi tanımlama
            string[] renkler = new string[5];
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };
            int[] dizi;
            dizi = new int[5];
            //dizilere değer atama ve erişim
            renkler[0] = "Mavi";
            Console.WriteLine(hayvanlar[1]);
            dizi[3] = 10;

            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //dönülerle dizi kullanımı
            //klavyeden girilen n tane sayının ortalamasını hesaplauan program
            Console.WriteLine("Lütfen dizinin eleman sayısını girin.");
            int diziuzunlugu = int.Parse(Console.ReadLine());
            int[] sayıDizisi = new int[diziuzunlugu];
            for (int i = 0; i <diziuzunlugu; i++)
            {
                Console.Write("Lütfen {0} . sayıyı giriniz:",i+1);
                sayıDizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var sayi in sayıDizisi)
            {
                toplam += sayi;
                
            }
            Console.WriteLine("Ortalama:" + toplam / diziuzunlugu);
        }
    }
}
