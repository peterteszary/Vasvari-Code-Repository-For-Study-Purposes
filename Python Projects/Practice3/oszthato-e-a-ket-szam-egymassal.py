# Definiálj egy függvényt, ami bekér két számot, és megállapítja, hogy a két szám osztható-e egymással.

def oszhtato():
    szam1 = int(input("Kérlek add meg az első számot: "))
    szam2 = int(input("Kérlek add meg a masodik számot: "))
    if szam1 % szam2 == 0:
        print("A két szám osztható egymással!")
    elif szam1 % szam2 != 0:
        print("A két szám nem osztható egymással!")
oszhtato()