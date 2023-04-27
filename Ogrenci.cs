using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiUyg
{
     class Ogrenci
    {
        static int sayi = 0;
        static int x;

        static string[] adSoyad = new string[100];
        static string[] numara = new string[100];
        static string[] bolum = new string[100];
        static string[] adres = new string[100];
        static string[] cinsiyet= new string[100];
        static string[] tel = new string[100];
      

        static void giris()
        {
            if( sayi== 100) {
                Console.WriteLine("Max bilgi girişine ulaştınız.");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Yeni bilgi girişi");

                Console.Write("Numara : ");
                numara[sayi] = Console.ReadLine();

                Console.Write("adSoyad : ");
                adSoyad[sayi] = Console.ReadLine();

                Console.Write("Bölüm : ");
                bolum[sayi] = Console.ReadLine();

                Console.WriteLine("Adres : ");
                adres[sayi] = Console.ReadLine();

                Console.Write("Cinsiyet : ");
                cinsiyet[sayi] = Console.ReadLine();

                Console.Write("Telefon : ");
                tel[sayi] = Console.ReadLine();

                Console.Write("Kayıt başarıyla tamamlandı");
                Console.ReadKey();
                sayi ++;            // Sonraki girişte sayı değişkeni bir artacak

            }
        }


        static void Lİstele()
        {
            int s = 0;
            Console.Write("AdSoyad      Bölüm       Telefon");

            for(int x = 0; x<sayi; x++) 
            {
                Console.WriteLine("{0,-30} {1,-15} {2,-15})",

                adSoyad[x], bolum[x], tel[x]);

                s++;    

                if(s % 10 == 0)             
                {
                    Console.WriteLine("Diğer sayfa için bir tuşa basınız");
                    Console.ReadKey();
                }
            }
        }
    


        static void arama()
        {

            string arama;

            int evet = 0;

            char cc;

            Console.Write("Aranan Ad Soyad : "); arama = Console.ReadLine();

            for ( x = 0; x < sayi; x++)
            {
                if (adSoyad[x] == arama)
                {
                    yaz();                   // Bilgilieri görüntülemeyi sağlar.
                    Console.Write("Aradığınız bilgi bu mu ? [E / H] ");
                    
                    do
                    {
                        cc = Convert.ToChar(Console.ReadLine());
                    } while (!(cc == 'h' || cc == 'H' || cc == 'e' || cc == 'E'));

                    if (cc == 'e' || cc == 'E')              // Aranan kişi ise
                    {
                        evet = 1;
                        break;              // Döngüden çık.
                    }
                }
            }

            if (evet == 0)              // Aranan kişi bulunamadıysa
            {
                Console.WriteLine("Aradığınız kişi listede yok");
                Console.WriteLine("Devam etmek için bir tuşa basınız");
                Console.ReadKey();
            }

        }




        static void yaz()
        {
            Console.WriteLine("Öğrencinin : ");
            Console.WriteLine("Numara : {0}", numara[x]);
            Console.WriteLine("Ad Soyad : {0}", adSoyad[x]);
            Console.WriteLine("Bölüm : {0}", bolum[x]);
            Console.WriteLine("Adres : {0}", adres[x]);
            Console.WriteLine("Telefon : {0}", tel[x]);
        }



        static void Main(string[] args)
        {
            char c;
            do
            {
                do
                {
                    Console.WriteLine("Ana Menü");
                    Console.WriteLine("1 - Bilgi Girişi");
                    Console.WriteLine("2 - Bilgi Listesi");
                    Console.WriteLine("3 - Bilgi Arama");
                    Console.WriteLine("4 - Bilgi Silme");
                    Console.WriteLine("5 - Program Sonu");
                    Console.WriteLine("Seçiminiz [1-5] : ");

                    c = Convert.ToChar(Console.ReadLine());

                    if (c == '1') giris();
                    if (c == '2') if (sayi > 0)  Lİstele();     // 2 tuşuna basıldığında Lstele bölümüne gider.
                    if (c == '3') if (sayi > 0) ; arama();
                    if (c == '4') if (sayi > 0) ;


                } while (c != '5');           // Programdan çıkış

                Console.WriteLine();

                    do
                {
                    c = Convert.ToChar(Console.ReadLine());

                } while (!(c == 'h' || c == 'H' || c == 'e' || c == 'E'));

            } while (!(c == 'E' || c == 'e'));
        }



    }

}
