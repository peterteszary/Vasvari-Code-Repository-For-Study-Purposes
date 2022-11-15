#Írjunk olyan programot, amely addig kér be egész számokat a billentyűzetről, amíg azok összege meg nem haladja a 100-at. Írjuk ki az összeget!
#be: szam, összeg > 100--> vége
#A beolvasás végén írjuk ki azt, hogy a bekért számok közül hány volt páros, és hány volt páratlan.

osszeg = 0
paros_db = 0
paratlan_db = 0

while osszeg <= 100:
    szam = int(input("Kérek egy számot: "))
    osszeg += szam

    if szam % 2 == 0:
        paros_db += 1
    else:
        paratlan_db += 1

    if osszeg <= 100:
        print("A számok részösszege: ", osszeg)

print("\nA számok végösszege: ", osszeg)
print("\n A páros számok száma: ", paros_db)
print("\n A páratlan számok száma: ", paratlan_db)