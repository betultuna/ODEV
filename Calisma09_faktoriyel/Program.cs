using System;

namespace Calisma09_faktoriyel
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            int faktoriyel = 1;
            System.Console.Write("Faktoriyelinin hesaplanmasını istediğiniz sayıyı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            for (int i =1 ; i <= sayi; i++)
            {
                faktoriyel *= i;
                
            }
            System.Console.WriteLine("Girdiğiniz sayının faktoriyeli: "+ faktoriyel);

            System.Console.WriteLine("Girdiğiniz sayının faktoriyeli: "+ faktoriyel1(sayi));
            
        }
        static int faktoriyel1(int a){ //döngüsüz hesaplama
                if(a>1)                
                return a * faktoriyel1(a - 1);
                else
                return a;
        }
        
    }
}
