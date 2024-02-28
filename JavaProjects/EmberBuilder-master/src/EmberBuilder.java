public class EmberBuilder {
    private String nev;
    private int szuletesiEv;
    private String lakhely;
    private  String email;


    public EmberBuilder setNev(String nev) {
        this.nev = nev;
        return this;
    }
    public EmberBuilder setszuletesiEv(int szuletesiEv) {
        this.szuletesiEv = szuletesiEv;
        return this;
    }

    public EmberBuilder setlakhely(String lakhely) {
        this.lakhely = lakhely;
        return this;
    }

    public EmberBuilder setemail(String email) {
        this.email = email;
        return this;
    }

    public Ember build() {return new Ember(nev, szuletesiEv, lakhely, email);
    }
}
