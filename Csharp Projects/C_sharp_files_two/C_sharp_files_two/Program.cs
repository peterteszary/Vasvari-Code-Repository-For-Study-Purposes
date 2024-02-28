using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace C_sharp_files_two
{
    class Program
    {
        public static void Main(string[] args)
        {
            if (!File.Exists(@"/home/peterteszary/Documents/GitHub/Vasvari-Code-Repository-For-Study-Purposes/C# PRojects/C_sharp_files_two/C_sharp_files_two/file.txt"))
            {
                //Create new file
                File.Create(@"/home/peterteszary/Documents/GitHub/Vasvari-Code-Repository-For-Study-Purposes/C# PRojects/C_sharp_files_two/C_sharp_files_two/file.txt");
            }
            else
            {
                //Read it
                string[] lines = File.ReadAllLines(@"/home/peterteszary/Documents/GitHub/Vasvari-Code-Repository-For-Study-Purposes/C# PRojects/C_sharp_files_two/C_sharp_files_two/file.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    Console.WriteLine(lines[i]);
                }

                //Open, Read
                string fileContent = File.ReadAllText(@"/home/peterteszary/Documents/GitHub/Vasvari-Code-Repository-For-Study-Purposes/C# PRojects/C_sharp_files_two/C_sharp_files_two/file.txt");
                Console.WriteLine(fileContent);

                //Replace
                string replaced = fileContent.Replace('e', 'o');

                //Save file
                File.WriteAllText(@"/home/peterteszary/Documents/GitHub/Vasvari-Code-Repository-For-Study-Purposes/C# PRojects/C_sharp_files_two/C_sharp_files_two/file2.txt", replaced);
                string[] newLines = { "egy", "kettő", "három" };
                File.WriteAllText(@"/home/peterteszary/Documents/GitHub/Vasvari-Code-Repository-For-Study-Purposes/C# PRojects/C_sharp_files_two/C_sharp_files_two/file3.txt", newLines);

                //Append file
               //File.AppendAllText(@"/home/peterteszary/Documents/GitHub/Vasvari-Code-Repository-For-Study-Purposes/C# PRojects/C_sharp_files_two/C_sharp_files_two/file2.txt", replaced);
            
            }

        }
    }
}
