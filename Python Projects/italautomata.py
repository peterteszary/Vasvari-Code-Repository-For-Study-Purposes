valasztas = ""
darabszam = 0
osszesen = valasztas * darabszam


italok = [("C", "c", "Cola", 260),
          ("N", "n", "Narancs", 290),
          ("R", "r", "Rostos", 330)]

res1 = [lis[0] for lis in italok]
res2 = [lis[1] for lis in italok]
res3 = [lis[2] for lis in italok]
res4 = [lis[3] for lis in italok]


print ("Italok" + str(res1))
print ("Italok" + str(res2))
print ("Italok" + str(res3))
print ("Italok" + str(res4))

while valasztas != "E" and valasztas != "e":


    print("Válasszon a tételek közül:")
    print("C - Cola (260 Ft)")
    print("N - Narancslé (290 Ft)")
    print("R - Rostos üdítő (330 Ft)")
    print("E - Kilépés")
    valasztas = input("Választás: ")
    darabszam = input("Darabszám: ")
    print(osszesen)




if valasztas == italok[1] or valasztas == italok[2] or valasztas == italok[3]:
    darabszam = int(input("Kérem, adja meg a darabszámot! "))
    print(osszesen)
if valasztas == "E" or valasztas == "e":
    print("OK")
else:
        print("\nRossz értéket adott meg, válasszon újra!")

print("Köszönöm a rendelést!")
