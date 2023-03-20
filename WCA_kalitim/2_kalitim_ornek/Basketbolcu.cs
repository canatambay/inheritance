using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_kalitim_ornek
{
    class Basketbolcu : Sporcu
    {
        int basketSayisi, yaptigiBloKAdedi;

        public int BasketSayisi { get => basketSayisi; set => basketSayisi = value; }
        public int YaptigiBloKAdedi { get => yaptigiBloKAdedi; set => yaptigiBloKAdedi = value; }

        public void BasketbolcuKaydet()
        {
            string BasketbolcuBilgileri = "Basketbolcu Bilgileri : " + Ad + " " + Soyad + " " + Yas + " " + Boy + " " + Kilo + " " + BasketSayisi + " " + YaptigiBloKAdedi;

            FileStream dosya2 = new FileStream("Basketbolcu.txt", FileMode.Append);

            StreamWriter dosyaYazici2 = new StreamWriter(dosya2);

            dosyaYazici2.WriteLine(BasketbolcuBilgileri);

            dosyaYazici2.Close();

        }

        public void BasketbolcuGoruntule()
        {
            try
            {
                FileStream dosya = new FileStream("Futbolcu.txt", FileMode.Open);

                StreamReader dosyaOkuyucu = new StreamReader(dosya);

                if (dosyaOkuyucu != null)
                {
                    Console.WriteLine(dosyaOkuyucu.ReadLine());
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Dosyanız Bulunamadı !!!");
            }
        }
    }
}
