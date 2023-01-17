# TODO Írj egy python scriptet, amely megnyitja a "telefonszamok.txt" fájlt, és minden sort egy listában tárol el.
# TODO Írj egy függvényt, amely megkapja a listát, és visszaadja azokat a telefonszámokat, amelyek +3630 kezdő számúak.
# TODO Írj egy függvényt, amely megkapja a listát, és visszaadja azokat a telefonszámokat, amelyek 7 hosszúak.
# TODO Írj egy függvényt, amely megkapja a listát, és visszaadja azokat a telefonszámokat, amelyekben az utolsó szám páratlan.
# TODO Írj egy függvényt, amely megkapja a listát, és visszaadja azokat a telefonszámokat, amelyekben az első szám 9.
# TODO Írj egy függvényt, amely megkapja a listát, és visszaadja azokat a telefonszámokat, amelyekben az utolsó 4 számjegy páros.
# TODO Írj egy függvényt, amely megkapja a listát, és visszaadja azokat a telefonszámokat, amelyekben az első 3 számjegy páratlan.
# TODO Írj egy függvényt, amely megkapja a listát, és visszaadja azokat a telefonszámokat, amelyekben az utolsó számjegy 0.
# TODO Írj egy függvényt, amely megkapja a listát, és visszaadja azokat a telefonszámokat, amelyekben az első két számjegy páros.
# TODO A feladatot akkor tekinted teljesítettnek, ha minden függvény jól működik és a kívánt eredményt adja.


# Első lépésben megnyitjuk a telefonszamok.txt fájlt, és minden sort egy listában tárolunk el
telefonszamok = []
with open("telefonszamok.txt", "r") as f:
    for line in f:
        telefonszamok.append(line.strip())

# Függvény, amely megkapja a listát, és visszaadja azokat a telefonszámokat, amelyek +3630 kezdő számúak
def kezd_3630(lista):
    return [szam for szam in lista if szam.startswith("+3630")]
print([szam for szam in lista if szam.startswith("+3630")])
# Függvény, amely megkapja a listát, és visszaadja azokat a telefonszámokat, amelyek 7 hosszúak
def hossz_7(lista):
    return [szam for szam in lista if len(szam) == 7]

# Függvény, amely megkapja a listát, és visszaadja azokat a telefonszámokat, amelyekben az utolsó szám páratlan
def utolso_paratlan(lista):
    return [szam for szam in lista if int(szam[-1]) % 2 != 0]

# Függvény, amely megkapja a listát, és visszaadja azokat a telefonszámokat, amelyekben az első szám 9
def elso_9(lista):
    return [szam for szam in lista if szam[0] == "9"]

# Függvény, amely megkapja a listát, és visszaadja azokat a telefonszámokat, amelyekben az utolsó 4 számjegy páros
def utolso_4_paros(lista):
    return [szam for szam in lista if int(szam[-4:]) % 2 == 0]

# Függvény, amely megkapja a listát, és visszaadja azokat a telefonszámokat, amelyekben az első 3 számjegy páratlan
def elso_3_paratlan(lista):
    return [szam for szam in lista if int(szam[:3]) % 2 != 0]