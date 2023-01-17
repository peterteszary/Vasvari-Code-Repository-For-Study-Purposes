#Definiálj egy függvényt, ami bekér egy számot, és megállapítja, hogy az páros vagy páratlan.

def paros_vagy_paratlan():
    szam = int(input("Kérlek add meg a számot: "))
    if szam % 2 == 0:
        print("A(z)", szam, "páros szám!")
    else:
        print("A(z)", szam, "nem páros szám!")

paros_vagy_paratlan()