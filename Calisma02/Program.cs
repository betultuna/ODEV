using System;

namespace Calisma01.Algoritma
{
    class Program
    {
        static void Main(string[] args)
        {

             // SORU 2
            // Kullancı '-' ile ayrılmış sayılar girer.
            // (Kullanıcı giriş yapmadan ENTER'a basarsa program sonlanacak.)
            // Girilen sayılar içinde tekrar eden varsa ekrana "TEKRAR VAR" yoksa "TEKRAR YOK" yazdırılacak.
            // (Kullanıcının doğru giriş yaptığı varsayılacak.)
            //
            // Tekrar olup olmadığını bulan algoritma bir metot olarak yazılacak
            // Metot; sayıları bir liste olarak alacak. Tekrar var ise TRUE yoksa FALSE değeri döndürecek.

            string giris = Console.ReadLine();


            if (!(giris == ""))
            {
                string[] girisler = giris.Split('-');
                int[] girislerSayi = new int[girisler.Length];

                // int çevirme
                for (int i = 0; i < girisler.Length; i++)
                {
                    girislerSayi[i] = Convert.ToInt32(girisler[i]);
                }

                // Algoritma
                int onceki = girislerSayi[0];




                

            }
            else{
            System.Console.WriteLine("Program Sonlandı");
            }
        }

    }


}
