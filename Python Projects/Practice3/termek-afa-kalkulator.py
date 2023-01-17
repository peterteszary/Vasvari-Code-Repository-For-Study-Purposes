#Definiálj egy függvényt, ami bekér egy termék árát és áfakulcsát, és visszaadja a termék végleges árát.

def afakulcs():
    while True:
        termek_ar = int(input("Kérem adja meg a termék árát: "))
        if termek_ar == "":
            break

        afa = int(input("Kérem adja meg az ÁFA kulcsot: "))
        osszeg_afaval = termek_ar + (termek_ar * afa / 100)

        print(f"A termák ára ÁFA-val együtt {osszeg_afaval:.0f} forint.")

afakulcs()