using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class program
    {
        static void Main(string[] args)
        {   //Számold meg melyik elemből hány darab van
            string[] items = new string[] { "zokni", "nadrág", "póló", "ing", "sapka" };
            Random r = new Random();
            int zokni = 0;
            int nadrag = 0;
            int polo = 0;
            int ing = 0;
            int sapka = 0;
            try
            {
                StreamWriter sw = new StreamWriter(@"result.txt", true, Encoding.UTF8);
                for (int i = 0; i < 50; i++)
                {
                    string item = items[r.Next(0, 5)];
                    sw.WriteLine(item);
                    switch (item)
                    {
                        case "zokni":
                            zokni++;
                            break;
                        case "nadrág":
                            nadrag++;
                            break;
                        case "póló":
                            polo++;
                            break;
                        case "ing":
                            ing++;
                            break;
                        case "sapka":
                            sapka++;
                            break;
                    }
                }
                sw.Flush();
                sw.Close();
            }
            catch (DirectoryNotFoundException)
            { Console.WriteLine("A könyvtár nem létezik!"); }
            catch (InvalidDataException) { Console.WriteLine("Ismeretlen hiba! "); }
            Console.ReadKey();
            //Eredmények visszaolvasása
            List<string> lista = new List<string>();
            try{

            }
            catch (FileNotFoundException) {Console.WriteLine("A file nem lérezik");}
            catch (IOException) {Console.WriteLine("Ismeretlen hiba! "); }   
        }
    }
}