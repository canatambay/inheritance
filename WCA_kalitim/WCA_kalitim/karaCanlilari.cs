using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCA_kalitim
{
    class karaCanlilari : Canli
    {
        private int CanliOrtalamaYasi;

        public int CanliOrtalamaYasi1 { get => CanliOrtalamaYasi; set => CanliOrtalamaYasi = value; }

        //----------------------

        public void SolunumYap()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Akciğer solunumu yapıldı ...");
        }

        public void Beslen()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Et ve Ot yendi ...");
        }
    }
}
