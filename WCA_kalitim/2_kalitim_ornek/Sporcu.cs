using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_kalitim_ornek
{
    class Sporcu // Ana / Ata Class
    {
        //Field

        string ad, soyad;
        int yas;
        float kilo, boy; //....


        //Kapsüllenmiş hali :
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public int Yas { get => yas; set => yas = value; }
        public float Kilo { get => kilo; set => kilo = value; }
        public float Boy { get => boy; set => boy = value; }
    }
}
