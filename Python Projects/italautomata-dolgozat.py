"""Azt a feladatot kapta, hogy italautomata programot készítsen
Cola    Narancslé   Rostos üdítő
260 Ft     290 Ft       330 Ft
"E" végjelig kérjük az adatokat (tétel neve, darabszám)"""

valasztas = "R"
cola_ar = 260
nar_ar = 290
rost_ar = 330
osszes_ar = 0

print("Kérem válasszon az ajánlataink közül!", end = "")
print("""
Cola      Narancslé   Rostos üdítő
260 Ft    290 Ft      330 Ft""")

while valasztas != "E" and valasztas != "e":             # E és kis e-re működjön
    valasztas = input("\nAjánlataink: (C)ola, (N)arancslé, (R)ostos, Kilépés (E): ")

    if valasztas == "E" or valasztas == "e":
        break

    if valasztas == "C" or valasztas == "N" or valasztas == "R" or valasztas == "r" or valasztas == "n" or valasztas == "c":
        darab = int(input("Kérem, adja meg a darabszámot! "))

    if valasztas == "C" or valasztas == "c":
        ar = darab * cola_ar
        osszes_ar += ar          # osszes_ar = osszes_ar + ar

    elif valasztas == "N" or valasztas == "n":
        ar = darab * nar_ar
        osszes_ar += ar

    elif  valasztas == "R" or valasztas == "r":
        ar = darab * rost_ar
        osszes_ar += ar

    else:
        print("\nRossz értéket adott meg, válasszon újra!")

print("Köszönöm a rendelést!")
print("A rendelés összege: ", osszes_ar)


