using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztalyok
{
    class Ember
    {
        public string Név;
        public int Életkor;
        public string Lakhely;
        public string Munkahely;
        public void Kiír()
        {
            Console.WriteLine("Név: " + Név);
            Console.WriteLine("Életkor: " + Életkor);
            Console.WriteLine("Lakhely: " + Lakhely);
            Console.WriteLine("Munkahely: " + Munkahely);
        }
    }
    class Kutya
    {
            public string Név;
            private int Éhségjelző = 50;

            public void Etet(int étel)
            {
                Éhségjelző -= étel;
            }

            public void Játék()
            {
                if (Éhségjelző <= 80)
                {
                    Éhségjelző += 50;
                    Console.WriteLine("Játék...");
                }
                else Console.WriteLine("A kutya túl éhes a játékhoz...");
            }

        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Ember e = new Ember();
            e.Név = "Sándor";
            e.Életkor = 40;
            e.Lakhely = "Makó";
            e.Munkahely = "Valami Kft.";

            Ember e2 = e; // Öröklés

            Ember e3 = e2; // Öröklés

            Console.WriteLine(e3.Lakhely);*/

            Kutya k = new Kutya();
            k.Játék();

            Console.ReadKey();
        }
    }
}
