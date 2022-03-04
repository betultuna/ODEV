using System;
using System.Collections.Generic;
// Kullanıcı 5 karakterli gönderim kodlarını girecek. (Örnek girişler: 06150, 07050, 34300 )
// 'x' karakteri girildiğinde veri girişi sonlanacak ve raporlama* yapılacak
// Gönderim kodunun ilk 2 karakteri varış şehrine ait kod : Ankara(06), Antalya(07), İstanbul (34)
// Gönderim kodunun sonraki 3 karakteri ağırlık (kg olarak) : 010 060 100 150 vs...
// olarak değerlendirilecek.
//    
// *Raporlama:  
// Şehirlere gidecek kargolar ayrı ayrı listelenecek ve toplam ağırlıklar yazdırılacak.
// Şehirlere gidecek olan araçlar maksimum 1000kg taşımaktadır. Gerekli araç sayısı hesaplanıp yazdırılacak.
// Tüm hatalı girişlerde kullanıcı bilgilendirilecek ve tekrar giriş istenecek.
//
// Örnek rapor: ("//" karakterleri , cs dosyasına kopyala/yapıştır yaparken kolaylık olsun diye konmuştur. Raporda yer almayacak.)


// Şehirler
// ========
// Ankara
// 300 kg
// 500 kg
// 1000 kg
// 100 kg

// Antalya
// 200 kg
// 500 kg
// 450 kg
// 400 kg
// 150 kg

// İstanbul
// 1000 kg
// 200 kg
// 1500 kg
// 500 kg
// ========

// Toplamlar
// Şehir - Toplam(kg) - Araç
// Ankara - 1900 - 2
// Antalya - 1700 - 2
// İstanbul - 3200 - 4
// =========

namespace Calisma04.Algoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Giriş
            string gonderimKodu = "06150";
            // Çevrimler sonrası
            string sehirKodu = "06";
            int kilo = 150;


            Dictionary<string, List<int>>  sehirKilolar = new Dictionary<string, List<int>>();

            //Dict başlangıç durumu

            
            


        }


    }
}
