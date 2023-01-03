italok = [("C", "c", "Cola", 260),
          ("N", "n", "Narancs", 290),
          ("R", "r", "Rostos", 330)]
valasztas = "R"
darabszam = 0
osszesen = valasztas * darabszam

while valasztas != "E" and valasztas != "e":
    print("Válasszon a tételek közül:")
    for item in italok:
        print(f"{item[0]} - {item[2]} ({item[3]} Ft)")
    print("E - Kilépés")
    valasztas = input("Választás: ")

    if valasztas == "E" or valasztas == "e":
        break

    item_selected = False
    for item in italok:
        if valasztas == item[0] or valasztas == item[1]:
            item_selected = True
            price = item[3]
            darabszam = int(input("Kérem, adja meg a darabszámot! "))
            print("Az ön által választott termék(ek) ára: ", price * darabszam, "Forint")
            break

    if not item_selected:
        print("\nRossz értéket adott meg, válasszon újra!")

print("Köszönöm a rendelést!")