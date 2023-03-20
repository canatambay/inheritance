using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2_kalitim_ornek
{
    class Program
    {
        public static object Tread { get; private set; }

        static void Main(string[] args)
        {

        Git:
            Console.Clear();
            Console.WriteLine("<<< Sporcu Ekleme Paneline Hoşgeldiniz >>>");
            Console.WriteLine("1- Futbolcu");
            Console.WriteLine("2- Basketbolcu");
            Console.WriteLine("------------------------------");
            Console.Write("Sporcunuzun branşını seçiniz : ");
            int secim = int.Parse(Console.ReadLine());
            if (secim == 1)
            {
                Fulbolcu yeniFutbolcu = new Fulbolcu();
                
                Console.WriteLine("\n------------------------------");
                Console.Write("Futbolcunun Adını Giriniz : ");
                yeniFutbolcu.Ad = Console.ReadLine();

                Console.Write("Sporcunun Soyadını Giriniz : ");
                yeniFutbolcu.Soyad = Console.ReadLine();

                Console.Write("Futbolcunun Yaşını Giriniz : ");
                yeniFutbolcu.Yas = int.Parse(Console.ReadLine());

                Console.Write("Futbolcunun Kilosunu Giriniz : ");
                yeniFutbolcu.Kilo = float.Parse(Console.ReadLine());

                Console.Write("Futbolcunun Boyunu Giriniz : ");
                yeniFutbolcu.Boy = float.Parse(Console.ReadLine());

            
                
                Console.Write("Futbolcunun Forma Numarasını Giriniz : ");
                yeniFutbolcu.FormaNo = int.Parse(Console.ReadLine());
                Console.Write("Futbolcunun Gol Sayısını Giriniz : ");
                yeniFutbolcu.GolSayisi = int.Parse(Console.ReadLine());
                Console.Write("Futbolcunun Takımını Giriniz : ");
                yeniFutbolcu.Takimi = Console.ReadLine();
                Console.Write("Futbolcunun Mevkiisini Giriniz : ");
                yeniFutbolcu.Mevkii = Console.ReadLine();

                Console.WriteLine("Kaydetmek İstemisiniz ? (e/h)");
                char cevap = char.Parse(Console.ReadLine());

                Console.WriteLine("Kaydediliyor ...");
                Thread.Sleep(1000);
                if (cevap == 'e')
                {
                    yeniFutbolcu.FutbolcuKaydet();

                    Console.WriteLine("Görüntülemek İstemisiniz ? (e/h)");
                    char gcevap = char.Parse(Console.ReadLine());
                    Console.WriteLine("Görüntüleniyor ...");
                    Thread.Sleep(1000);
                    Console.Clear();
                    if (gcevap == 'e')
                    {
                        yeniFutbolcu.FutbolcuGoruntule();
                        Console.WriteLine("\n---------------------------------\n");
                        Console.WriteLine("Tekrar Veri Girmek İster misiniz ? (e/h)");
                        char bcevap = char.Parse(Console.ReadLine());
                        if (bcevap == 'e')
                        {
                            goto Git;
                        }
                        else
                        {

                            Console.Clear();
                            Console.WriteLine("Çıkış Yapılıyor ...");
                            Thread.Sleep(1000);
                        }
                    }
                }
            }

            if (secim == 2)
            {
                Basketbolcu yeniBasketbolcu = new Basketbolcu();

                Console.WriteLine("\n------------------------------");
                Console.Write("Basketbolcunun Adını Giriniz : ");
                yeniBasketbolcu.Ad = Console.ReadLine();

                Console.Write("Basketbolcunun Soyadını Giriniz : ");
                yeniBasketbolcu.Soyad = Console.ReadLine();

                Console.Write("Basketbolcunun Yaşını Giriniz : ");
                yeniBasketbolcu.Yas = int.Parse(Console.ReadLine());

                Console.Write("Basketbolcunun Kilosunu Giriniz : ");
                yeniBasketbolcu.Kilo = float.Parse(Console.ReadLine());

                Console.Write("Basketbolcunun Boyunu Giriniz : ");
                yeniBasketbolcu.Boy = float.Parse(Console.ReadLine());



                Console.Write("Basketbolcunun Basket Sayısını Giriniz : ");
                yeniBasketbolcu.BasketSayisi = int.Parse(Console.ReadLine());
                Console.Write("Basketbolcunun Gol Sayısını Giriniz : ");
                yeniBasketbolcu.YaptigiBloKAdedi = int.Parse(Console.ReadLine());

                Console.WriteLine("Kaydetmek İstemisiniz ? (e/h)");
                char cevap = char.Parse(Console.ReadLine());

                Console.WriteLine("Kaydediliyor ...");
                Thread.Sleep(1000);
                if (cevap == 'e')
                {
                    yeniBasketbolcu.BasketbolcuKaydet();

                    Console.WriteLine("Görüntülemek İstemisiniz ? (e/h)");
                    char gcevap = char.Parse(Console.ReadLine());
                    Console.WriteLine("Görüntüleniyor ...");
                    Thread.Sleep(1000);
                    Console.Clear();
                    if (gcevap == 'e')
                    {
                        yeniBasketbolcu.BasketbolcuGoruntule();
                        Console.WriteLine("\n---------------------------------\n");
                        Console.WriteLine("Tekrar Veri Girmek İster misiniz ? (e/h)");
                        char bcevap = char.Parse(Console.ReadLine());
                        if (bcevap == 'e')
                        {
                            goto Git;
                        }
                        else
                        {

                            Console.Clear();
                            Console.WriteLine("Çıkış Yapılıyor ...");
                            Thread.Sleep(1000);
                        }
                    }
                }
            }

        }
    }
}
