public class Ember {
    private String nev;
    private int szuletesiEv;
    private String lakhely;
    private  String email;

    public Ember(String nev, int szuletesiEv, String lakhely, String email) {
        this.nev = nev;
        this.szuletesiEv = szuletesiEv;
        this.lakhely = lakhely;
        this.email = email;
    }

    @Override
    public String toString() {
        return "Ember{" +
                "nev='" + nev + '\'' +
                ", szuletesiEv=" + szuletesiEv +
                ", lakhely='" + lakhely + '\'' +
                ", email='" + email + '\'' +
                '}';
    }
}
