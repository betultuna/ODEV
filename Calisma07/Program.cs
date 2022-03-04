using System;

namespace KisiNakit
{
    class Program
    {
        static void Main(string[] args)
        {

            // Casino(0.50);
            // BorcAlVer();
        }


        /// <summary>
        /// Bu bir Casino oyunudur.
        /// </summary>
        /// <param name="sans">oyundaki kazanma şans faktörü</param>
        private static void Casino(double sans)
        {
            // double sans = .75;
            Random r = new Random();
            Kisi oyuncu = new Kisi("OYUNCU", 100);
            Console.WriteLine("Casino'ya hoşgeldiniz. Şansınız " + sans);

            while (oyuncu.Nakit > 0)
            {
                oyuncu.BilgileriYaz();
                Console.Write("Oynamak istediğiniz miktar nedir?(Çıkış için ENTER) ");
                string neKadar = Console.ReadLine();

                if (neKadar == "") return;

                if (int.TryParse(neKadar, out int miktar))
                {
                    int pot = oyuncu.NakitVer(miktar) * 2;
                    if (pot > 0)
                    {
                        if (r.NextDouble() > sans)
                        {
                            int kazanilan = pot;
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write("KAZANDINIZ! : " + kazanilan);
                            Console.ResetColor();
                            oyuncu.NakitAl(kazanilan);
                            System.Console.WriteLine();
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write("Kaybettiniz :(");
                            Console.ResetColor();
                            System.Console.WriteLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Geçerli bir miktar giriniz...");
                }
            }
            Console.WriteLine("Kasa hep kazanır :)");
        }

        /// <summary>
        /// Basit bir Kişi Nakit Al Ver simülasyonu...
        /// </summary>
        private static void BorcAlVer()
        {
            var a = new Kisi("Ali", 50);
            var v = new Kisi("Veli", 50);

            while (true)
            {
                a.BilgileriYaz();
                v.BilgileriYaz();
                // Ne kadar?
                Console.Write("Ne kadar?");
                int miktar = Convert.ToInt32(Console.ReadLine());

                // Kim?
                Console.Write("Kim nakit veriyor (a ya da v : ");
                string kim = Console.ReadLine();

                if (kim == "a")
                {
                    int m = a.NakitVer(miktar);
                    v.NakitAl(m);

                }
                else if (kim == "v")
                {
                    int m = v.NakitVer(miktar);
                    a.NakitAl(m);
                }
                else
                {
                    System.Console.WriteLine("Doğru giriş yapın..");
                }
            }
        }
    }
}
