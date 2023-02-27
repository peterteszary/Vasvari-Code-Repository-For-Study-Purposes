using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace C_sharp_files
{
    class Program
    {
        public static void Main(string[] args)
        {
            if (!File.Exists(@"/Documents/GitHub/Vasvari-Code-Repository-For-Study-Purposes/C# PRojects/C_sharp_files/C_sharp_files/file.txt"))
            {
                //Create new file
                File.Create(@"/Documents/GitHub/Vasvari-Code-Repository-For-Study-Purposes/C# PRojects/C_sharp_files/C_sharp_files/file.txt");
            }
            else 
            {
                //Read it
                string [] lines = File.ReadAllLines(@"/Documents/GitHub/Vasvari-Code-Repository-For-Study-Purposes/C# PRojects/C_sharp_files/C_sharp_files/file.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    Console.WriteLine(lines[i]);
                }
                string fileContent = File.ReadAllText(@"/Documents/GitHub/Vasvari-Code-Repository-For-Study-Purposes/C# PRojects/C_sharp_files/C_sharp_files/file.txt");
                Console.WriteLine(fileContent);
            }

        }
    }
}
