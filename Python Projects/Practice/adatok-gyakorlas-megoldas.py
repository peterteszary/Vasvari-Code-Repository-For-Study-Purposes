#1. létrehozunk egy adatok.txt fájlt és benne van a megadott adatok

#2.
def adatok_beolvasasa():
    adatok = []
    with open("adatok.txt", "r") as file:
        for sor in file:
            adatok.append(sor.strip().split(","))
    return adatok

#3.
def f_kereso(lista):
    f_lista = []
    for adat in lista:
        if adat[2] == "F":
            f_lista.append(adat)
    return f_lista

#4.
def kor_kereso(lista):
    kor_lista = []
    for adat in lista:
        if int(adat[1]) > 30:
            kor_lista.append(adat)
    return kor_lista

#5.
def helyszin_kereso(lista):
    hely_lista = []
    for adat in lista:
        if adat[3] == "Budapest":
            hely_lista.append(adat)
    return hely_lista

#6.
def betu_kereso(lista):
    betu_lista = []
    for adat in lista:
        if adat[0][0] == "A":
            betu_lista.append(adat)
    return betu_lista

#7.
def paros_szam_kereso(lista):
    paros_lista = []
    for adat in lista:
        if int(adat[1])%2 == 0:
            paros_lista.append(adat)
    return paros_lista

#8.
def hossz_kereso(lista):
    hossz_lista = []
    for adat in lista:
        if len(adat[3]) > 5:
            hossz_lista.append(adat)
    return hossz_lista

#9.
def nagybetu_kereso(lista):
    nagybetu_lista = []
    for adat in lista:
        if adat[0][0].isupper():
            nagybetu_lista.append(adat)
    return nagybetu_lista

#10.
def betu_veg_kereso(lista):
    betu_veg_lista = []
    for adat in lista:
        if adat[3][-1] == "s":
            betu_veg_lista.append(adat)
    return betu_veg_lista

adatok = adatok_beolvasasa()
f_lista = f_kereso(adatok)
print(f_lista)

kor_lista = kor_kereso(adatok)
print(kor_lista)