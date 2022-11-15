using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace konzol_alk
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam1 = 100;
            int szam2;
            int csere;

            Console.Write("Kérek egy egész számot: ");
            szam2 = Convert.ToInt32(Console.ReadLine());

            csere = szam1;
            szam1 = szam2;
            szam2 = csere;

            Console.WriteLine("szam 1: " + szam1);
            Console.WriteLine("szam 2: " + szam2);


            Console.WriteLine("Összeg: " + (szam1 + szam2));
            Console.WriteLine("Különbség: " + (szam1 - szam2));
            double hanyados = (double)szam1 / szam2;
            Console.WriteLine("Hányados: " + szam1 / szam2);
            Console.WriteLine("Szorzat: " + (szam1 * szam2));
            Console.WriteLine("Négyzet: " + (szam1 * szam2));
            Console.WriteLine("Maradék: " + (szam1 % szam2));


            Console.ReadKey();
        }

    }

}