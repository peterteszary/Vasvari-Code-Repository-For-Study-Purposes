using System;

class KitalalosJatek
{
    static void Main()
    {
        // Generáljunk egy véletlen számot 0 és 20 között
        Random random = new Random();
        int talaltSzam = random.Next(0, 21);
        int tippekSzama = 0;

        // Kérjünk tippeket a felhasználótól, amíg el nem találja a generált számot
        while (true)
        {
            Console.Write("Tippelj egy számot 0 és 20 között: ");
            string bemenet = Console.ReadLine();

            // Ellenőrizzük, hogy a bemenet érvényes egész-e
            if (!int.TryParse(bemenet, out int tipp))
            {
                Console.WriteLine("Érvénytelen bemenet. Kérlek adj meg egy számot.");
                continue;
            }

            // Ellenőrizzük, hogy a bemenet a megadott tartományban van-e
            if (tipp < 0 || tipp > 20)
            {
                Console.WriteLine("Érvénytelen bemenet. Kérlek adj meg egy számot 0 és 20 között.");
                continue;
            }

            // Ellenőrizzük, hogy a tipp helyes-e
            if (tipp == talaltSzam)
            {
                tippekSzama++;
                Console.WriteLine("Gratulálok! {0}. tippeléssel találtad el a számot", tippekSzama);

                if (tippekSzama <= 2)
                {
                    Console.WriteLine("Lucky Man!");
                }
                else if (tippekSzama <= 5)
                {
                    Console.WriteLine("Ügyes voltál!");
                }
                else if (tippekSzama <= 7)
                {
                    Console.WriteLine("Lehet a helyedben más játékot választanék.");
                }
                else
                {
                    Console.WriteLine("Lehet lottóznod sem érdemes!");
                }
                break;
            }
            else
            {
                tippekSzama++;
                Console.WriteLine("Hibás! Próbálkozz újra.");
            }
        }
    }
}
