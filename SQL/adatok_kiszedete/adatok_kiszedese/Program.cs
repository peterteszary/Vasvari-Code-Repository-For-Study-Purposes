using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] soraim =
            {
                "21; George Bush; [1698671]; beet",
                "23; Donald Trump; [167253]; root",
                "5; Törpapa; [50]; áfonya",
                "900; Pál Kata Péter; [12345]; alma",
                "87; Sándor József Benedek; [9867523]; paradicsom",
            }; // NEM vezérelt szerk., tehát kell a;

        string minta = "";

        Regex ellenorzo = new Regex(minta);

        foreach (string s in soraim)
        {
            var eredmeny = ellenorzo.Match(s);

            if (eredmeny.Success) 
            {
                int id = Convert.ToInt32(eredmeny.Groups["id"].Value);
                string nev = eredmeny.Groups["nev"].Value;

                int fizu = Convert.ToInt32(eredmeny.Groups["fizu"].Value);
                string ennivalo = eredmeny.Groups["ennivalo"].Value;

                // elkészítjük az INSERT INTO parancsot
                string SQL_parancsom = String.Format();
                $"INSERT INTO presidents (id, name, wage, veggie) VALUES ('1', 'G. Washington', '123' 'zeller', );"
            }
    }

}

}
