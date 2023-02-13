using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace diak_strukt
{
    class Program
    {

        struct Diák
        {
            public string név;
            public int életkor;
            public string lakhely;
            public List<int> jegyei;

            public Diák(string név, int k, string h)
            {
                this.név = név;
                this.életkor = k;
                this.lakhely = h;
                this.jegyei = null;


            }

            public void kiír()
            { 
                Console.WriteLine("Név: " + név);
                Console.WriteLine("Életkor: " + életkor);
                Console.WriteLine("Lakhely: " + lakhely);
                Console.WriteLine("Jegyei: ");
                foreach (int item in this.jegyei) 
                {
                    Console.Write(item + ", ");
                }
                Console.WriteLine("\n\nA diák átlaga:" + Átlag());
            }
            public double Átlag() 
            {
                int osszeg = 0;
                foreach (int item in this.jegyei) 
                {
                    osszeg += item;
                }
                return osszeg / (double)this.jegyei.Count;
            }
            

        }
        static void Main(string[] args)
        {
            Console.Write("Adja meg a tanuló nevét: ");
            string nev = Console.ReadLine();
            Console.Write("Adja meg az életkorát: ");
            int eletkor = int.Parse(Console.ReadLine());
            Console.Write("Adja meg a lakhelyét: ");
            string lakhely = Console.ReadLine();
            Diák d = new Diák(nev, eletkor, lakhely);
            d.jegyei = new List<int>();
            for (int i = 0; i < 5; i++) 
            {
                Console.Write("\nAdja meg a(z) " + (i+1) + ".számot >>> ");
                d.jegyei.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("A tanuló adatai: ");
            d.kiír();
            Console.ReadKey();
        }
    }
}
