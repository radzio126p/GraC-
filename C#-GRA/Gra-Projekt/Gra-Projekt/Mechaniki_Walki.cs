using System;
using System.Collections.Generic;
using System.Text;

namespace Gra_Projekt
{
    class Mechaniki_Walki
    {
        public int Odpocznij(ref Wojska_Gracza gr, ref Trasa tr)
        {
            foreach (Dywizja names in gr.oddzialy_Gracza)
            {

                names.Zycie = 100;
            }
            Dywizja zdw1 = new Dywizja("Piechota");
            tr.trasa_nap[tr.Aktualna_Pozycja + 1].Wojska_W_Miesc.Add(zdw1);
            Statystyki.ilosc_ruchow++;
            return 1;
        }
        public void Atakuj(ref Wojska_Gracza gr, ref Trasa tr)
        {
            Statystyki.ilosc_ruchow++;
            if (tr.trasa_nap[tr.Aktualna_Pozycja +1].Wojska_W_Miesc.Count == 0)
            {
                tr.Aktualna_Pozycja = tr.Aktualna_Pozycja + 1;
                gr.Majatek = gr.Majatek + tr.trasa_nap[tr.Aktualna_Pozycja].Wartosc_Podbicia;
                if(tr.trasa_nap[tr.Aktualna_Pozycja].Nazwa == "Moskwa")
                {
                    Console.WriteLine("BRAWO UDAŁO CI SIĘ ZDOBYĆ MOSKWĘ !!!!");
                    Statystyki.Stat(gr);
                    Console.WriteLine("Wciscij dowolny przycisk aby kontynuować");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
                Console.WriteLine("Bitwa Wygrana  brawo !!!");
                Console.WriteLine("Wciscij dowolny przycisk aby kontynuować");
                Console.ReadKey();
                return;
            }
            if(gr.oddzialy_Gracza.Count == 0)
            {
                Console.WriteLine("Bitwa Przegrana");
                Console.WriteLine("Wciscij dowolny przycisk aby kontynuować");
                Console.ReadKey();
                return;

            }

            while (true)
            {
                
                if(gr.oddzialy_Gracza[0].Sila_Ataku >= tr.trasa_nap[tr.Aktualna_Pozycja + 1].Wojska_W_Miesc[0].Zycie)
                {
                    tr.trasa_nap[tr.Aktualna_Pozycja + 1].Wojska_W_Miesc.RemoveAt(0);

                }
                else
                {
                    tr.trasa_nap[tr.Aktualna_Pozycja + 1].Wojska_W_Miesc[0].Zycie = tr.trasa_nap[tr.Aktualna_Pozycja + 1].Wojska_W_Miesc[0].Zycie - gr.oddzialy_Gracza[0].Sila_Ataku;
                }
                if (tr.trasa_nap[tr.Aktualna_Pozycja + 1].Wojska_W_Miesc.Count == 0)
                {
                    gr.Majatek = gr.Majatek + tr.trasa_nap[tr.Aktualna_Pozycja+1].Wartosc_Podbicia;
                    tr.Aktualna_Pozycja = tr.Aktualna_Pozycja + 1;
                    if (tr.trasa_nap[tr.Aktualna_Pozycja].Nazwa == "Moskwa")
                    {
                        Console.WriteLine("BRAWO UDAŁO CI SIĘ ZDOBYĆ MOSKWĘ !!!!");
                        Statystyki.Stat(gr);
                        Console.WriteLine("Wciscij dowolny przycisk aby kontynuować");
                        Console.ReadKey();
                        System.Environment.Exit(0);
                    }

                    Console.WriteLine("Bitwa Wygrana !!!");
                    Console.WriteLine("Wciscij dowolny przycisk aby kontynuować");
                    Console.ReadKey();
                    return;
                }
                if(tr.trasa_nap[tr.Aktualna_Pozycja + 1].Wojska_W_Miesc[0].Sila_Ataku >= gr.oddzialy_Gracza[0].Zycie)
                {
                    gr.oddzialy_Gracza.RemoveAt(0);
                }
                else
                {
                    gr.oddzialy_Gracza[0].Zycie = gr.oddzialy_Gracza[0].Zycie - tr.trasa_nap[tr.Aktualna_Pozycja + 1].Wojska_W_Miesc[0].Sila_Ataku;

                }
                if (gr.oddzialy_Gracza.Count == 0)
                {
                    Console.WriteLine("Bitwa Przegrana");
                    Console.WriteLine("Wciscij dowolny przycisk aby kontynuować");
                    Console.ReadKey();
                    return;

                }
            }

        }

        public void Wycofaj(ref Wojska_Gracza gr, ref Trasa tr)
        {
            Statystyki.ilosc_ruchow++;
            if (tr.Aktualna_Pozycja == 0)
            {
                Console.WriteLine("                 Przegrałeś");
                Statystyki.Stat(gr);
                Console.WriteLine("Wciscij dowolny przycisk aby kontynuować");
                Console.ReadKey();
                System.Environment.Exit(0);

            }
            else
            {
                Dywizja wdw1 = new Dywizja("Piechota");
                Dywizja wdw2 = new Dywizja("Kawaleria");
                Dywizja wdw3 = new Dywizja("Artyleria");
                gr.oddzialy_Gracza.Add(wdw3);
                tr.trasa_nap[tr.Aktualna_Pozycja].Wojska_W_Miesc.Add(wdw1);
                tr.Aktualna_Pozycja = tr.Aktualna_Pozycja - 1;
            }
        }
        public void Sklep(ref Wojska_Gracza gr)
        {
            Console.Clear();
            Dywizja sdw1 = new Dywizja("Piechota");
            Dywizja sdw2 = new Dywizja("Kawaleria");
            Dywizja sdw3 = new Dywizja("Artyleria");
            Console.WriteLine("Oto menu werbunku: ");
            Console.WriteLine("Wybierz kogo chcesz zwerbować");
            Console.WriteLine("1.Dywizja piechoty (50 franków)");
            Console.WriteLine("2.Dywizja kawalerii (70 franków)");
            Console.WriteLine("3.Dywizja artylerii (100 franków)");
            Console.WriteLine("4.Wstecz");
            ConsoleKeyInfo klawisz = Console.ReadKey();
            switch (klawisz.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    if (gr.Majatek >= 50)
                    {
                        gr.Majatek -= 50;
                        gr.oddzialy_Gracza.Add(sdw1);
                    }
                    else
                    {
                        Console.WriteLine("Niewystarczajaca ilosc franków");
                        Console.WriteLine("Wciscij dowolny przycisk aby kontynuować");
                        Console.ReadKey(true);
                    }

                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    if (gr.Majatek >= 70)
                    {
                        gr.Majatek -= 70;
                        gr.oddzialy_Gracza.Add(sdw2);
                    }
                    else
                    {
                        Console.WriteLine("Niewystarczajaca ilosc franków");
                        Console.WriteLine("Wciscij dowolny przycisk aby kontynuować");
                        Console.ReadKey(true);
                    }


                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    if (gr.Majatek >= 100)
                    {
                        gr.Majatek -= 100;
                        gr.oddzialy_Gracza.Add(sdw3);
                    }
                    else
                    {
                        Console.WriteLine("Niewystarczajaca ilosc franków");
                        Console.WriteLine("Wciscij dowolny przycisk aby kontynuować");
                        Console.ReadKey(true);
                    }
                    break;
                case ConsoleKey.D4:
                    Console.Clear();

                    break;
                default:

                    break;

            }
        }
    }
}
