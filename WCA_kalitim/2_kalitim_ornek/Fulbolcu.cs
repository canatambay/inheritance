using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_kalitim_ornek
{
    class Fulbolcu : Sporcu
    {

        int formaNo, golSayisi;
        string takimi, mevkii;

        public int FormaNo { get => formaNo; set => formaNo = value; }
        public int GolSayisi { get => golSayisi; set => golSayisi = value; }
        public string Takimi { get => takimi; set => takimi = value; }
        public string Mevkii { get => mevkii; set => mevkii = value; }

        public void FutbolcuKaydet()
        {
            string FulbolcuBilgileri = "Fulbolcu Bilgileri : " + Ad + " " + Soyad + " " + Yas + " " + Boy + " " + Kilo + " " + Takimi + " " + FormaNo + " " + GolSayisi + " " + Mevkii;

            FileStream dosya = new FileStream("Futbolcu.txt",FileMode.Append);

            StreamWriter dosyaYazici = new StreamWriter(dosya);

            dosyaYazici.WriteLine(FulbolcuBilgileri);

            dosyaYazici.Close();

        }

        public void FutbolcuGoruntule()
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
