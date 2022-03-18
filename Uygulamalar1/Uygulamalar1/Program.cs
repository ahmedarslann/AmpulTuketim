using System;

namespace Uygulamalar1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ekrandan kullanıcı girdisi alma 
            //string girdi = Console.Readline();

            //int sayi;
            //Console.WriteLine("merhabalar bir sayi giriniz:");
            //string girdi = Console.ReadLine();
            //sayi = Convert.ToInt32(girdi);
            //Console.WriteLine(sayi + 2);
            //Console.ReadLine();

            // 1- kullanıcıdan alınan sayının karesini alma uygulaması 

            //int sayi;
            //Console.WriteLine("lütfen bir sayi giriniz:");
            //string girilen = Console.ReadLine();
            //sayi = Convert.ToInt32(girilen);
            //int kare = sayi * sayi;
            //Console.WriteLine("sayinin karesi :" + kare);
            //Console.ReadLine();

            //2- toplama uygulaması 
            // ekranda girilen 2 sayısı toplayan uygulamayı yazınız 


            //int s1, s2;
            //Console.WriteLine("1.sayıyı giriniz");
            //string giris1 = Console.ReadLine();
            //Console.WriteLine("2.sayiyi giriniz");
            //string giris2 = Console.ReadLine();

            //int toplam = Convert.ToInt32(giris1) + Convert.ToInt32(giris2);
            //Console.WriteLine("toplam:" + toplam);
            //Console.ReadLine();


            //3- tasarruf hesapalama
            // kaç ampul ? kaç saat ?
            // normal ampul saatte 2 tl
            // tasarruflu ise %20
            // çıktı olarak normal ampul faturası , tasarruflu fatura 

            int ampulSayisi, saat;
            float fiyat = 2;

            Console.WriteLine("tasarruf hesaplama programına hoşgeldiniz \n lütfen kaç ampul kullandığınızı yazın:");
            ampulSayisi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kaç saat kullanıyorsunuz:");
            saat = Convert.ToInt32(Console.ReadLine());

            float faturaTutari = ampulSayisi * saat * fiyat;
            float tasarrufluTutar = faturaTutari * 80 / 100;
            Console.WriteLine("normal ampul tutarı:" + faturaTutari);
            Console.WriteLine("tasarrufluTutari:" + tasarrufluTutar);
            Console.ReadLine();


        }
    }
}
