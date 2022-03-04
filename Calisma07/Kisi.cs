using System;

namespace KisiNakit
{
    class Kisi
    {
        public string Ad;
        public int Nakit;

        public Kisi(string ad,int nakit)
        {
            Ad = ad;
            Nakit = nakit;
        }

        public void BilgileriYaz()
        {
            Console.WriteLine(Ad + " diyor ki: cebimdeki nakit " + Nakit);
        }

        public int NakitVer(int miktar)
        {
            // negatif olmaz
            if (miktar <= 0)
            {
                Console.WriteLine(Ad + " diyor ki: " + miktar + " geçerli bir miktar değil!");
                return 0;
            }
            // fazla istedi
            if (miktar > Nakit)
            {
                Console.WriteLine(Ad + " diyor ki: " +
                    "Sana verecek yeterli nakitim yok " + miktar + "Elimde olanı veriyorum " + Nakit);
                Nakit = 0;
                return Nakit;
            }
            // 
            Nakit -= miktar;
            return miktar;
        }

        public void NakitAl(int miktar)
        {
            if (miktar <= 0)
            {
                Console.WriteLine(Ad + " diyor ki : " + miktar + " geçerli bir miktar değil.");
            }
            else
            {
                Nakit += miktar;
            }
        }
    }

}