public class Main {
    public static void main(String[] args) {
        Ember ember = new EmberBuilder()
                .setNev("Teszáry Péter")
                .setlakhely("6772 Deszk, Béke utca 36/c")
                .setemail("peterteszary@gmail.com")
                .setszuletesiEv(1985)
                .build();
        System.out.println(ember);
    }
}