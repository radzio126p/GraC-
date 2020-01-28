using System;
using System.Collections.Generic;
using System.Text;

namespace Gra_Projekt
{
    class Dywizja
    {

        public string Nazwa_Jednostki { set; get; } 
        public int Sila_Ataku { set; get; }
        public int Zycie { set; get; }
        public Dywizja(string nazwa_J) //konstruktor
        {
            this.Zycie = 100;
            this.Nazwa_Jednostki = nazwa_J;
            if(this.Nazwa_Jednostki == "Piechota")
            {
                this.Sila_Ataku = 30;
            }
            else if(this.Nazwa_Jednostki == "Kawaleria")
            {
                this.Sila_Ataku = 50;
            }
            else if (this.Nazwa_Jednostki == "Artyleria")
            {
                this.Sila_Ataku = 60;
            }
        }

    }
}
