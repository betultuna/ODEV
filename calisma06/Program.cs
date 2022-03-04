using System;

namespace Odev.Nokta
{
    class NoktaTest
    {           
        static void Main()
        {
            Nokta p1 = new Nokta(2, 3);
            Nokta p2 = new Nokta(3, 4);
            Console.WriteLine(p1.UzaklikHesapla(p2));
        }
    }
    class Nokta
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Nokta(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double UzaklikHesapla(Nokta n)
        {


            return 3;
        }
    }




}