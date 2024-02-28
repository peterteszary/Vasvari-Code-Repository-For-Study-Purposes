using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace kerulet_terulet_alk
{
    class Program
    {
        static void Main(string[] args)
        {
            //Olvassuk be egy négyzet oldalának hosszát, majd számítsuk ki a kerületét és területét.

            Console.Write("Kérem a négyzet oldalának hosszát (cm): ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kerület: " + (4 * a) + "cm");
            Console.WriteLine("Terület: " + (a * a) + "cm2");

            Console.ReadKey();
 
        }
    }
}