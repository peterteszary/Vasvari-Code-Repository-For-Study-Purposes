


# Ezek csak a kísérlet részeri

#res1 = [lis[0] for lis in italok]
#res2 = [lis[1] for lis in italok]
#res3 = [lis[2] for lis in italok]
#res4 = [lis[3] for lis in italok]

#print ("Italok" + str(res1))
#print ("Italok" + str(res2))
#print ("Italok" + str(res3))
#print ("Italok" + str(res4))






while valasztas != "E" and valasztas != "e":

    if valasztas == "E" or valasztas == "e":
        break

    italok = [("C", "c", "Cola", 260),
              ("N", "n", "Narancs", 290),
              ("R", "r", "Rostos", 330)]
    valasztas = "R"
    darabszam = 0
    osszesen = valasztas * darabszam

    result1 = [val for val in italok[0] if isinstance(val, (int, float))]
    result2 = [val for val in italok[1] if isinstance(val, (int, float))]
    result3 = [val for val in italok[2] if isinstance(val, (int, float))]

    print("Válasszon a tételek közül:")
    print("C - Cola (260 Ft)")
    print("N - Narancslé (290 Ft)")
    print("R - Rostos üdítő (330 Ft)")
    print("E - Kilépés")
    valasztas = input("Választás: ")

    if valasztas == "C" == result1:
        darabszam = input(int("Kérem, adja meg a darabszámot! "))
        print(result1 + darabszam)
    if valasztas == "N":
        betu2 = "N" == result2
        darabszam = int(input("Kérem, adja meg a darabszámot! "))
        print(result2 + darabszam)
    if valasztas == "R":
        betu3 = "R" == result2
        darabszam = int(input("Kérem, adja meg a darabszámot! "))
        print(result3 + darabszam)

    else:
            print("\nRossz értéket adott meg, válasszon újra!")

    print("Köszönöm a rendelést!")
