using System;

namespace Calisma03

{       // Kulllanıcı bir kelime girer.
        // Kelimedeki sesli harflerin sayısını bulan programı yazınız.
        // Program büyük/küçük harfe duyarlı olmalı
        //
        // Sesli sayısını bulan algoritma bir metot olarak yazılacak
        // Metot; giriş bilgisini string olarak alacak. Sesli sayısını int olarak döndürecek.

    class Program
    {

        static void Main(string[] args)
        {
            char[] harfler = { 'a','A', 'e','E' ,'ı','I','İ', 'i', 'o','O','Ö', 'ö', 'u','U','Ü', 'ü' };
            string metin;
            int sayac = 0;
            Console.WriteLine("Metin giriniz : ");
            metin = Console.ReadLine();
            for (int i = 0; i < harfler.Length; i++)
            {
                for (int j = 0; j < metin.Length; j++)
                {
                    if (metin[j] == harfler[i])
                    {
                        sayac++;
                    }
                }
            }
            Console.WriteLine(sayac+" adet sesli harf mecvut");
            
        }


    }
}

