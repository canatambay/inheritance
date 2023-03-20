using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCA_kalitim
{
    class denizCanlilari : Canli
    {
        private int CanliOrtalamaYasi;

        public int CanliOrtalamaYasi1 { get => CanliOrtalamaYasi; set => CanliOrtalamaYasi = value; }

        //----------------------

        public void SolunumYap()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Solungaç solunumu yapıldı ...");
        }

        public void Beslen()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Plankton yendi ...");
        }
    }
}
