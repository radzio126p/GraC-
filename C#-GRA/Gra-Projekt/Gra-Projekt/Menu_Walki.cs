using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Gra_Projekt
{
    class Menu_Walki
    {
        public void Wyswietl_Informacje(List<Dywizja> gr, List<Dywizja> wr, Wojska_Gracza wg,Trasa tr) //wyswietla aktualne informacje
        {

            Wyswietl_mapa.wyswietl_mape(tr);
            int i = 1;
            Console.WriteLine("Jednostki Gracza: ");
            foreach (Dywizja names in gr)
            {

                Console.Write(i);
                Console.Write(") " + names.Nazwa_Jednostki + " życie: " + names.Zycie.ToString() + " siła ataku: " + names.Sila_Ataku.ToString() + "\n");
                i++;
            }
            int k = 1;
            Console.WriteLine("Jednostki Wroga: ");
            foreach (Dywizja names in wr)
            {

                Console.Write(k);
                Console.Write(") " + names.Nazwa_Jednostki + " życie: " + names.Zycie.ToString() + " siła ataku: " + names.Sila_Ataku.ToString() + "\n");
                k++;
            }
            Console.Write("Majątek wynosi: ");
            Console.Write(wg.Majatek);
            Console.WriteLine(" franków");
        }

        public int Wyswietl_Menu_Walki(ref Wojska_Gracza gr, ref Trasa tr, Mechaniki_Walki mech)
        {

            Console.Clear();

            Wyswietl_Informacje(gr.oddzialy_Gracza, tr.trasa_nap[tr.Aktualna_Pozycja+1].Wojska_W_Miesc,gr,tr);
            Console.WriteLine("");
            Console.Write("1.Atakuj następny teren - ");
            Console.WriteLine(tr.trasa_nap[tr.Aktualna_Pozycja + 1].Nazwa);
            Console.WriteLine("2.Odpocznij (Wszystkie dywizje gracza 100% zycia -przeciwnik dostaje 1 dywizje piechoty)");
            Console.WriteLine("3.Werbuj");
            Console.WriteLine("4.Wycofaj się (Gracz otrzymuje dywizje artylerii na wycofanym terenie pojawia się dywizja piechoty wroga)");
            ConsoleKeyInfo klawisz = Console.ReadKey();
            switch (klawisz.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    mech.Atakuj(ref gr, ref tr);
                    
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    mech.Odpocznij(ref gr, ref tr);
                    

                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    mech.Sklep(ref gr);
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    mech.Wycofaj(ref gr, ref tr);
                    break;
                default:

                    break;


            }
            return 1;
        }
    }
}
