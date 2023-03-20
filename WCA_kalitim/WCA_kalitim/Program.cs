using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCA_kalitim
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kalıtım (Miras) - Inheritance :

            // Ör : kendimize bir "Canlı" ana classı oluşturalım ve  alt sekme olarak kara ve deniz canlılarını da class olarak oluşturalım.

            denizCanlilari dc = new denizCanlilari();
            dc.SolunumYap();
            dc.Beslen();

            // --------
            dc.CanliYasi = 250;
            Console.WriteLine(dc.CanliYasi +"\n");

            karaCanlilari kc = new karaCanlilari();
            kc.SolunumYap();
            kc.Beslen();

            // --------
            kc.CanliYasi = 97;
            Console.WriteLine(kc.CanliYasi + "\n");

            Console.ReadLine();



        }
    }
}
