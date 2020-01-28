using System;
using System.Collections.Generic;
using System.Text;

namespace Gra_Projekt
{
    class Miejsce_Bitwy
    {
        public string Posiadacz { set; get; } //kto jest posiadaczem
        public string Nazwa { set; get; } //nazwa miejsca bitwy


        public int Wartosc_Podbicia { set; get; } //nagroda za podbicie

        public List<Dywizja> Wojska_W_Miesc = new List<Dywizja>(); //wojska stacjonujace w miescie
        public Miejsce_Bitwy(string naz,string pos,int wart,List<Dywizja> dywizj) //konstruktor
        {
            this.Nazwa = naz;
            this.Posiadacz = pos;
            this.Wartosc_Podbicia = wart;
            this.Wojska_W_Miesc = dywizj;
        }
        
        
    }
}
