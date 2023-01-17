# Definiálj egy függvényt, ami bekér két számot, és megállapítja, hogy melyik szám a nagyobb.

def melyik_a_nagyobb():
    szam1 = int(input("Add meg az első számot: "))
    szam2 = int(input("Add meg a második számot: "))

    if szam1 > szam2:
        print(szam1, "nagyobb mint", szam2)
    elif szam2 > szam1:
        print(szam2, "nagyobb mint", szam1)
    elif szam1 == szam2:
        print(szam1, "és", szam2, "egyenlő.")
melyik_a_nagyobb()