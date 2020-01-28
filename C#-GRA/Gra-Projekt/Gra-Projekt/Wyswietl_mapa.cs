using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Gra_Projekt
{
    class Wyswietl_mapa
    {
        public static void wyswietl_mape(Trasa tr)
        {
            string trasa = "mapa";
            trasa += tr.Aktualna_Pozycja.ToString();
            trasa += ".txt";
            
            string[] lines = File.ReadAllLines(trasa);

            foreach (string line in lines)
                Console.WriteLine(line);
        }
    }
}
