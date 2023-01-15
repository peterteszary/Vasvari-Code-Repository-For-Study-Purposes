import random

#lista létrehozása az adatok tárolására
tetelek = []

# file beolvasása és encoding utf-8
forras = open("itallap.txt", encoding="utf-8")

# for each-el végig megyek az adatokon, stip-el az üres sorokat törlöm, split-el pedig feldarabolom
for adat in forras:
    adat = adat.strip().split()

# a következő módon tárolom őket at adat nevű változóban:
    tetelek.append(adat)

# az adatfeltöltéshez létre kell hoznom változókat kezdőértékekkel amikben eltárolom majd az új tételeket
nev = "kezdo"

# Addig fut amíg a felhasználó nem üt egy V-t
while nev != "V":
    nev = input("Add meg az új tétel nevét! ")

# Ha V-t üt a felhasználó, akkor a program kilép.
    if nev == "V":
        break
    kat = input("Add meg az új tétel kategóriáját! ")
    ar = input("Add meg a tétel árát! ")

# Itt fűzöm hozzá a tételeket a listához, de listaként [kapcsos zárójelben az adott sorrendben] kell hozzáadnom, mert alapvetően csak 1 elemet lehet hozzáadni ezzel a módszerrel.
    tetelek.append([nev, kat, ar])

# így írjuk ki hogy az adatbázisunk hány tételt tartalmaz

hossz = len(tetelek) # lista hossza
print("Az adatbázisban található tételek száma: ", hossz) # így iratom ki

"""Írja ki az ital kategóriájú tételeket a képernyőre, vesszővel és szóközzel elválasztva."""

# ha tetelek[i][1] == "i" --> tetelek[i][0] tárolja el.

ital = []
for i in range(len(tetelek)):
    if tetelek[i][1] == "i":
        ital.append(tetelek[i][0]) # itt azért nulla van a kapcsos zárójelek között, mert a 17 elemű lista első eleme nulla
print("Az italok:",", ".join(ital))     # a join hozzá fűzi az elemek között a vesszőt és a szóközt.

"""Írja ki az ezer forintnál drágább tételek neveit a képrenyőre"""
kiemelt = [] # tárolom őket egy listában

# első módszer:
for i in tetelek: # i = index hivatkozás
    if int(i[2]) > 1000:
        kiemelt.append(i[0])
print(kiemelt)

# második módszer:
kiemelt2 = []
for i in range(len(tetelek)):
    if int(tetelek[i][2]) > 1000:
        kiemelt2.append(tetelek[i][0])
    print(kiemelt2)
# irassa ki véletlenszerűen az egyik árú nevét a képernyőre!

# neveket kigyűjtöm, majd ebből választok véletlenszerűen
nev = [i[0] for i in tetelek]
print("Egy tétel véletlenszerűen: ", random.choice(nev))
print(nev)

#létre kell hozni a kiemeltajanlat.txt-t és ki kell írni az 1000 Ft-nál nagyobb tételeket
kiiras = []
for tetel in tetelek:
    if int(tetel[2]) > 1000:
        kiiras.append(tetel)
forras.close() # előző file lezárása

cel = open("kiemeltajanlat.txt", "w", encoding="utf-8")

for adat in kiiras:
    print(" ".join(adat), file=cel)