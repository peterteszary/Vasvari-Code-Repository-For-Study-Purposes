# Definiálj egy függvényt, ami bekér egy listát és egy számot, és visszaadja, hogy a szám hányszor szerepel a listában.
lista = []
def hanyszor():
    while True:
        szam = int(input("Add meg a listához tartozó számot (0 a kilépéshez): "))
        if szam == 0:
            break
        lista.append(szam)
        print(lista)
        keresett_szam = int(input("Add meg a listában keresendő számot: "))
        talalat = 0
        for szam in lista:
            if szam == keresett_szam:
                talalat += 1
        print("A keresett szam {} alkalommal található meg a listában. ".format(talalat))
hanyszor()