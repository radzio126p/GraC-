using System;
using System.Collections.Generic;
using System.Text;

namespace Gra_Projekt
{
    class Wojska_Gracza
    {
        public int Majatek { set; get; }
        public List<Dywizja> oddzialy_Gracza = new List<Dywizja>();
        public Wojska_Gracza()
        {
            Majatek = 100;
            Dywizja oddpiech = new Dywizja("Piechota");
            Dywizja oddpiech1 = new Dywizja("Piechota");


            Dywizja oddkawal1 = new Dywizja("Kawaleria");
            Dywizja oddartyle = new Dywizja("Artyleria");
            this.oddzialy_Gracza.Add(oddpiech);
            this.oddzialy_Gracza.Add(oddpiech1);
            this.oddzialy_Gracza.Add(oddkawal1);



        }
    }
}
