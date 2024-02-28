using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string val = "Whatewert we want we";
            string val2 = "whatewer";
            Console.WriteLine(val);

            Console.WriteLine(val.ToUpper());

            Console.WriteLine(val);

            Console.WriteLine(val.ToLower().Contains(val2));

            Console.WriteLine(val.LastIndexOf('t'));
            Console.WriteLine(val.Length);

            Console.WriteLine(val.Replace('w', 'j'));
            Console.WriteLine(val.Replace("we", "ssss"));

            Console.WriteLine(val.Remove(3));
            Console.WriteLine(val.Remove(2, val.Length - 4));

            Console.WriteLine(val.Substring(3));
            Console.WriteLine(val.Substring(3,5));
            Console.WriteLine(val.Substring(val.Length - 3));

            Console.WriteLine(val.StartsWith("wha"));
            Console.WriteLine(val.EndsWith("we"));

            string url = "         www.goo gle.com ssasd/as/dasd/asd/asd     ";
            string[] part = url.Split(' ');
            Console.WriteLine(part[0]);

            Console.WriteLine(url);
            Console.WriteLine(url.Trim());


        }
    }
}
