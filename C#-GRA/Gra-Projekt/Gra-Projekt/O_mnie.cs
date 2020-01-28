using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Gra_Projekt
{
    class O_mnie //wyswietlanie informacji o mnie
    {
        public static void o_mnie()
        {
            string[] lines = File.ReadAllLines("omnie.txt");

            foreach (string line in lines)
                Console.WriteLine(line);
        }

    }
}
