# Írj egy programot ami kiszámítja az ágazati írásbeli vzsgán elért pontszám alapján az elért eredményt százalékosan.
def szazalek():

    while True:
        nev = input("Add meg a hallgató nevét: ")
        if nev == "":
            break
        pontszam = int(input("Add meg a pontszámot: "))
        pontszam_szazalek = pontszam / 30 * 100

        print(f"A {nev} nevű hallgató százalékos pontszáma: {pontszam_szazalek:.0f}%")

szazalek()

