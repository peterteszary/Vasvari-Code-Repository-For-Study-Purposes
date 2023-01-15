#italautomata - Teszáry Péter

italok = [("C", "c", "Cola", 260),
          ("N", "n", "Narancs", 290),
          ("R", "r", "Rostos", 330)]
valasztas = "R"
darabszam = 0
osszesen = valasztas * darabszam

while valasztas != "E" and valasztas != "e":
    print("Válasszon a tételek közül:")
    for ital in italok:
        print(f"{ital[0]} - {ital[2]} ({ital[3]} Ft)")
    print("E - Kilépés")
    valasztas = input("Választás: ")

    if valasztas == "E" or valasztas == "e":
        break

    valasztott_ital = False
    for ital in italok:
        if valasztas == ital[0] or valasztas == ital[1]:
            valasztott_ital = True
            ar = ital[3]
            darabszam = int(input("Kérem, adja meg a darabszámot! "))
            print("Az ön által választott termék(ek) ára: ", ar * darabszam, "Forint")
            break

    if not  valasztott_ital:
        print("\nRossz értéket adott meg, válasszon újra!")

print("Köszönöm a rendelést!")