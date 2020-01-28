using System;
using System.Collections.Generic;
using System.Text;

namespace Gra_Projekt
{
    class Tworzenie_Miejsc //tworzenie miejsc i oddzialow w miejscach
    {
        public Miejsce_Bitwy m1_franf;
        public Miejsce_Bitwy m2_erfur;
        public Miejsce_Bitwy m3_kowno;
        public Miejsce_Bitwy m4_wilno;
        public Miejsce_Bitwy m5_polock;
        public Miejsce_Bitwy m6_witebsk;
        public Miejsce_Bitwy m7_smolensk;
        public Miejsce_Bitwy m8_dorogobuz;
        public Miejsce_Bitwy m9_wiazma;
        public Miejsce_Bitwy m10_gzack;
        public Miejsce_Bitwy m11_borodino;


        public Miejsce_Bitwy mk_moskwa;
        public Tworzenie_Miejsc()
        {
            List<Dywizja> p1k1 = new List<Dywizja>();
            Dywizja oddpiech2 = new Dywizja("Piechota");

            Dywizja oddpiech = new Dywizja("Piechota");
            Dywizja oddkawal = new Dywizja("Kawaleria");
            Dywizja oddartyle = new Dywizja("Artyleria");
            Dywizja oddpiech1 = new Dywizja("Piechota");
            Dywizja oddkawal1 = new Dywizja("Kawaleria");
            Dywizja oddartyle1 = new Dywizja("Artyleria");
            Dywizja oddpiech3 = new Dywizja("Piechota");
            Dywizja oddkawal3 = new Dywizja("Kawaleria");
            Dywizja oddartyle3 = new Dywizja("Artyleria");


            Dywizja oddpiechm3 = new Dywizja("Piechota");
            Dywizja oddkawalm3 = new Dywizja("Kawaleria");
            Dywizja oddartylem3 = new Dywizja("Artyleria");


            p1k1.Add(oddpiech);
            p1k1.Add(oddkawal);
            List<Dywizja> p1 = new List<Dywizja>();
            p1.Add(oddpiech2);
            List<Dywizja> p1k1a1 = new List<Dywizja>();
            p1k1a1.Add(oddpiech3);
            p1k1a1.Add(oddkawal3);
            p1k1a1.Add(oddartyle3);

            List<Dywizja> kowno = new List<Dywizja>();
            kowno.Add(oddpiechm3);
            kowno.Add(oddartylem3);
            kowno.Add(oddartylem3);

            List<Dywizja> wilno = new List<Dywizja>();
            Dywizja oddkawalm4 = new Dywizja("Kawaleria");
            wilno.Add(oddkawalm4);

            List<Dywizja> polock = new List<Dywizja>();
            Dywizja oddkawalm5 = new Dywizja("Kawaleria");
            Dywizja oddpiechm5 = new Dywizja("Piechota");
            polock.Add(oddkawalm5);
            polock.Add(oddpiechm5);

            List<Dywizja> witebsk = new List<Dywizja>();
            Dywizja oddkawalm6 = new Dywizja("Kawaleria");
            Dywizja oddpiech1m6 = new Dywizja("Piechota");
            witebsk.Add(oddkawalm6);
            witebsk.Add(oddpiech1m6);

            List<Dywizja> smolensk = new List<Dywizja>();
            Dywizja oddkawalm7 = new Dywizja("Kawaleria");
            Dywizja oddartylem7 = new Dywizja("Artyleria");
            smolensk.Add(oddkawalm7);
            smolensk.Add(oddartylem7);

            List<Dywizja> dorogobuz = new List<Dywizja>();
            Dywizja oddkawalm8 = new Dywizja("Kawaleria");
            Dywizja oddpiechm8 = new Dywizja("Piechota");
            Dywizja oddpiech1m8 = new Dywizja("Piechota");
            dorogobuz.Add(oddkawalm8);
            dorogobuz.Add(oddpiechm8);
            dorogobuz.Add(oddpiech1m8);



            List<Dywizja> wiazma = new List<Dywizja>();
            Dywizja oddkawalm9 = new Dywizja("Kawaleria");
            Dywizja oddkawal1m9 = new Dywizja("Kawaleria");
            wiazma.Add(oddkawalm9);
            wiazma.Add(oddkawal1m9);


            List<Dywizja> gzack = new List<Dywizja>();
            Dywizja oddkawalm10 = new Dywizja("Kawaleria");
            Dywizja oddartylem10 = new Dywizja("Artyleria");
            gzack.Add(oddkawalm10);
            gzack.Add(oddartylem10);


            List<Dywizja> borodino = new List<Dywizja>();
            Dywizja oddkawalm11 = new Dywizja("Kawaleria");
            Dywizja oddartylem11 = new Dywizja("Artyleria");
            Dywizja oddpiechm11 = new Dywizja("Piechota");
            borodino.Add(oddkawalm11);
            borodino.Add(oddartylem11);
            borodino.Add(oddpiechm11);






            this.m1_franf = new Miejsce_Bitwy("Franfurkt","Francja", 50, p1);
            this.m2_erfur = new Miejsce_Bitwy("Erfurt","Rosja", 60, p1k1);
            this.m3_kowno = new Miejsce_Bitwy("Kowno", "Rosja", 60, kowno);
            this.m4_wilno = new Miejsce_Bitwy("Wilno", "Rosja", 40, wilno);
            this.m5_polock = new Miejsce_Bitwy("Połock", "Rosja", 50, polock);
            this.m6_witebsk = new Miejsce_Bitwy("Witebsk", "Rosja", 70, witebsk);
            this.m7_smolensk = new Miejsce_Bitwy("Smoleńsk", "Rosja", 80, smolensk);
            this.m8_dorogobuz = new Miejsce_Bitwy("Dorogobuż", "Rosja", 100, dorogobuz);
            this.m9_wiazma = new Miejsce_Bitwy("Wiaźma", "Rosja", 90, wiazma);
            this.m10_gzack = new Miejsce_Bitwy("Gżack", "Rosja", 90, gzack);
            this.m11_borodino = new Miejsce_Bitwy("Borodino", "Rosja", 100, borodino);
            
            this.mk_moskwa = new Miejsce_Bitwy("Moskwa", "Rosja", 80, p1k1a1);
        }
    }
}
