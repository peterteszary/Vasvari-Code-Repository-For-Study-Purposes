# Definiálj egy függvényt, ami bekér egy diák jegyeit, és visszaadja a diák átlagjegyét.

def jegyatlag():
    while True:
        nev = input("Kérlek add meg a diák nevét: ")
        if nev == "":
            break
        jegy1 = int(input("Kérlek add meg az első osztályzatot: "))
        jegy2 = int(input("Kérlek add meg a második osztályzatot: "))
        jegy3 = int(input("Kérlek add meg a harmadik osztályzatot: "))

        atlag = (jegy1 + jegy2 + jegy3) / 3
        print(f"A {nev} hallgató jegyátlaga: {atlag}")

jegyatlag()