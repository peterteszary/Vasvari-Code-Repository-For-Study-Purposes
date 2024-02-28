using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SzamonkeresTeszaryPeter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bekérjük a felhasználótól, hogy mennyi számot szeretne sorsolni
            Console.WriteLine("Hány számot szeretneél kisorsolni?");
            int szamDb = int.Parse(Console.ReadLine());
            // Random objektum létrehozása a véletlenszerű számok generálásához
            Random random = new Random();

            // Sorsolunk szamDb darab számot 1 és 5000 között és eltároljuk azokat a szamok listában
            List<int> szamok = new List<int>();
            for (int i = 0; i < szamDb; i++)
            {
                int szam = random.Next(1, 5001);
                szamok.Add(szam);
            }

            // A sorsolt számokat eltároljuk egy fájlban
            string sorsoltSzamokFilename = "SorsoltSzámok.txt";
            Console.WriteLine($"Számok mentése a következő fájlba: SorsoltSzámok.txt");

            using (StreamWriter writer = new StreamWriter(sorsoltSzamokFilename))
            {
                foreach (int szam in szamok)
                {
                    writer.WriteLine(szam);
                }
            }

            // Szétválogatjuk a páros és páratlan számokat két külön listába
            List<int> parosSzamok = new List<int>();
            List<int> paratlanSzamok = new List<int>();

            foreach (int szam in szamok)
            {
                if (szam % 2 == 0)
                {
                    parosSzamok.Add(szam);
                }
                else
                {
                    paratlanSzamok.Add(szam);
                }
            }

            // A páros számokat eltároljuk egy fájlban
            string parosSzamokFilename = "PárosSzámok.txt";
            Console.WriteLine($"Páros számok mentése a következő fájlba: parosSzamok.txt");
            using (StreamWriter writer = new StreamWriter(parosSzamokFilename))
            {
                foreach (int szam in parosSzamok)
                {
                    writer.WriteLine(szam);
                }
            }

            // A páratlan számokat eltároljuk egy fájlban
            string paratlanSzamokFilename = "PáratlanSzámok.txt";
            Console.WriteLine($"Páratlan számok mentése a következő fájlba: paratlanSzamok.txt");
            using (StreamWriter writer = new StreamWriter(paratlanSzamokFilename))
            {
                foreach (int szam in paratlanSzamok)
                {
                    writer.WriteLine(szam);
                }
            }

            Console.WriteLine($"Az összes szám átlaga: {szamok.Average()}");
            Console.WriteLine($"A páros számok átlaga: {parosSzamok.Average()}");
            Console.WriteLine($"A páratlan számok átlaga: {paratlanSzamok.Average()}");
        }
    }
}