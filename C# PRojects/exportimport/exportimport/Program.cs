using System.ComponentModel;
using System.Threading.Tasks;
using System.IO;

namespace exportimport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exportálás
            List<int> lista = new List<int>();
            List<int> paros = new List<int>();
            List<int> paratlan = new List<int>();
            int paros_db = 0;
            int paratlan_db = 0;
            Random r = new Random();
            StreamWriter sw = new StreamWriter("result.txt", false);
            for (int i = 0; i < 1000; i++)
            {
                lista.Add(r.Next(1, 5000));
                sw.Write(lista[i] + ";");
                if (lista[i] % 2 == 0)
                {
                    paros.Add(lista[i]);
                    paros_db++;
                }
                else
                {
                    paratlan.Add(lista[i]);
                    paratlan_db++;
                }
            }
            lista.Sort();
            foreach (var item in lista)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n\nA lista kapacitása: " + lista.Capacity);
            Console.WriteLine("A lista elemeinek száma: " + lista.Count);
            Console.WriteLine("A lista 34. eleme: " + lista[33]);
            Console.WriteLine("Páros elemek száma: " + paros_db);
            Console.WriteLine("Páratlan elemek száma: " + paratlan_db);


            /* int[] tomb = new
              foreach (var item in tomb)
            {
            Console.Write(item + " ");
            }*/
            sw.Flush();
            sw.Close();
            Console.ReadKey();

            //importálás
            Console.WriteLine("-  -  -");
            StreamReader sr = new StreamReader("result.txt");
            string str;
            while (!sr.EndOfStream) 
            {
                str = sr.ReadLine();
                string[] str_tomb = str.Split(';');
                foreach (var item in str_tomb)

                {
                    Console.WriteLine(item);
                }
                int osszeg = 0;
                foreach (var item in str_tomb)
                {
                    osszeg += Convert.ToInt32(item); 
                }
                Console.WriteLine("A számok összege: " + osszeg);
            }
            
            Console.ReadKey();

        }
    }
}