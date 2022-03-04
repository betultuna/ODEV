using System;

namespace Calisma12.Algoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            // SORU 1
            // Kullanıcı '-' ile ayrılmış şekilde sayılar girer.
            // Sayıların ardışıl olup olmadığını bulan programı yazınız. 
            // Örneğin girilen sayılar "5-6-7-8-9" veya "20-19-18-17-16" ise
            // Ekrana "Ardışıl", değilse "Ardışıl Değil" yazdırın.
            // (Kullanıcının doğru giriş yaptığı varsayılacak.)
            // 
            // Sayıların ardışıl olup olmadığını bulan algoritma bir metot olarak yazılacak.
            // Metot; sayıları bir liste olarak alacak. Ardışıl ise TRUE değilse false değeri döndürecek.

            string giris = "5-6-7-8-9-10-2";
            string[] girisler = giris.Split('-');

            int[] girislerSayi = new int[girisler.Length];

            // int çevirme
            for (int i = 0; i < girisler.Length; i++)
            {
                girislerSayi[i] = Convert.ToInt32(girisler[i]);
            }

            // Algoritma
            int onceki = girislerSayi[0];
            bool ardisil = false;

            for (int i = 1; i < girislerSayi.Length; i++)
            {
                if (girislerSayi[i] == onceki + 1)
                {
                    onceki = girislerSayi[i];
                    ardisil = true;
                }
                else
                {
                    ardisil = false;
                    break;
                }
            }

            string mesaj = ardisil ? "Ardışıl" : "Ardışıl değil";

            System.Console.WriteLine(mesaj);

        }

      
    }
}
