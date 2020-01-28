using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Gra_Projekt
{
    class Statystyki //wyswietlanie statystyk gracza i zapis do pliku
    {
        public static int ilosc_ruchow;
        public static void Stat ( Wojska_Gracza gr)
        {
            string[] t = new string[4];
            Console.WriteLine("                 Statystyki:");
            t[1] = "                 Statystyki:";
            Console.Write("Ilosc ruchów: ");
            t[2] = "Ilosc ruchów: " + Statystyki.ilosc_ruchow.ToString();
            Console.WriteLine(Statystyki.ilosc_ruchow);
            t[3] = "Ilosć monet: " + gr.Majatek.ToString();
            Console.Write("Ilosć monet: ");
            Console.WriteLine(gr.Majatek);
            File.WriteAllLines("statystyki.txt", t);


        }
        
    }
}
