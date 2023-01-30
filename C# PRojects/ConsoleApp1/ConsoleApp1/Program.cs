using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string[] items = new string[] { "zokni", "nadrág", "póló", "ing", "sapka" };
        Random r = new Random();
        try
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\bsze2tespet\Documents\GitHub\Vasvari-Code-Repository-For-Study-Purposes\C# PRojects\filewrite\app\Program.cs", true, Encoding.utf - 8);
            for (int i = 0; i < 500; i++)
            {
                sw.WriteLine(items[r.Next(0, 4)]);
            }
            sw.Flush();
            sw.Close();
        }

        catch (DirectoryNotFoundException) { Console.WriteLine("A könyvtár nem létezik!"); }
        catch (IOException) { Console.WriteLine("Ismeretlen hiba!"); }

    }

}