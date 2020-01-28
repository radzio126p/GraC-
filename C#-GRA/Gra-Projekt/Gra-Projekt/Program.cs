using System;
using System.IO;
using System.Collections.Generic;

namespace Gra_Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(150,  40); //ustawienie wielkosci konsoli
            Menu.WyswietlMenu(); //wyswietlenie menu
            Statystyki.ilosc_ruchow = 0;
            Wojska_Gracza gracz1 = new Wojska_Gracza(); //inicjalizacja obiektow
            Trasa tr1 = new Trasa();
            Menu_Walki mw1 = new Menu_Walki();
            Mechaniki_Walki mech1 = new Mechaniki_Walki();
            while (true)
            {
                mw1.Wyswietl_Menu_Walki(ref gracz1, ref tr1, mech1); //nieskonczona petla menu walki

            }
            









        }
    }
}
