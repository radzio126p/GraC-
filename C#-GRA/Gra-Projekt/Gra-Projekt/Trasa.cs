using System;
using System.Collections.Generic;
using System.Text;

namespace Gra_Projekt
{
     class Trasa //trasa napoleona
    {
        public List<Miejsce_Bitwy> trasa_nap = new List<Miejsce_Bitwy>(); //lista miejsc bitwy
        public int Aktualna_Pozycja { set; get; } //numer polozenia aktualnego

        public Trasa() //konstruktor trasy
        {
            Aktualna_Pozycja = 0;
            Tworzenie_Miejsc tw1 = new Tworzenie_Miejsc();
            this.trasa_nap.Add(tw1.m1_franf);
            this.trasa_nap.Add(tw1.m2_erfur);
            this.trasa_nap.Add(tw1.m3_kowno);
            this.trasa_nap.Add(tw1.m4_wilno);
            this.trasa_nap.Add(tw1.m5_polock);
            this.trasa_nap.Add(tw1.m6_witebsk);
            this.trasa_nap.Add(tw1.m7_smolensk);
            this.trasa_nap.Add(tw1.m8_dorogobuz);
            this.trasa_nap.Add(tw1.m9_wiazma);
            this.trasa_nap.Add(tw1.m10_gzack);
            this.trasa_nap.Add(tw1.m11_borodino);
            this.trasa_nap.Add(tw1.mk_moskwa);


        }

    }
}
