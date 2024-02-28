using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace split
{
    class Program 
    {
        static void Main(string[] args) 
        {

            string szoveg = "Az én nevem Teszáry Péter";
            string[] szoveg_tomb = szoveg.Split(' ');
            foreach (var item in szoveg_tomb) 
            {
                console.WriteLine(item);
            
            }
            Console.WriteLine("A szöveg 4. szava: " + szoveg_tomb[3]);
            Console.ReadKey();
        }
    }

}