using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Gra_Projekt
{
    class Menu
    {
        static public void WyswietlMenu() //menu glowne
        {


            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            string[] lines = File.ReadAllLines("test.txt");

            foreach (string line in lines)
                Console.WriteLine(line);
            Console.WriteLine("1.Zagraj");
            Console.WriteLine("2.O grze");
            Console.WriteLine("3.Wyjście");
            ConsoleKeyInfo klawisz = Console.ReadKey();
            switch (klawisz.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("Witaj w grze");
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    O_mnie.o_mnie();
                    Console.ReadKey();
                    WyswietlMenu();
                    break;
                case ConsoleKey.D3:
                    System.Environment.Exit(0);
                    break;
                default:
                    WyswietlMenu();
                    break;


            }


        }

    }
}
