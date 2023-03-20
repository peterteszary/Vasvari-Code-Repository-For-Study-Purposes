import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.*;

public class NepszeruProgramozasiNyelvek {

    public static void main(String[] args) {
        List<String> nyelvek = new ArrayList<>();
        Map<String, Integer> nyelvGyakorisag = new HashMap<>();

        // fájl beolvasása
        try {
            nyelvek = Files.readAllLines(Paths.get("programozasinyelvek.txt"));
        } catch (IOException e) {
            System.err.println("Hiba történt a fájl beolvasása közben: " + e.getMessage());
            System.exit(1);
        }

        // nyelvek gyakoriságának meghatározása
        for (String nyelv : nyelvek) {
            if (nyelvGyakorisag.containsKey(nyelv)) {
                nyelvGyakorisag.put(nyelv, nyelvGyakorisag.get(nyelv) + 1);
            } else {
                nyelvGyakorisag.put(nyelv, 1);
            }
        }

        // gyakoriság alapján rendezés
        List<Map.Entry<String, Integer>> entryList = new ArrayList<>(nyelvGyakorisag.entrySet());
        entryList.sort(Map.Entry.comparingByValue(Comparator.reverseOrder()));

        // legnépszerűbb nyelvek kiírása
        System.out.println("Legnépszerűbb programozási nyelvek:");
        for (Map.Entry<String, Integer> entry : entryList) {
            System.out.println(entry.getKey() + " (" + entry.getValue() + " alkalommal)");
        }

        // abc sorrendbe rendezés
        List<String> sortedList = new ArrayList<>();
        for (String nyelv : nyelvek) {
            if (!sortedList.contains(nyelv)) {
                sortedList.add(nyelv);
            }
        }
        Collections.sort(sortedList);

        // abc sorrendbe rendezett lista kiírása fájlba
        try {
            Files.write(Paths.get("kimenet.txt"), sortedList);
        } catch (IOException e) {
            System.err.println("Hiba történt a fájl írása közben: " + e.getMessage());
        }
    }
}
