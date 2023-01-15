adatok_lista = []

forras = open("adatok.txt", encoding="utf-8")

for sor in forras:
    sor = sor.strip().split(", ")
    adatok_lista.append(sor)
    print(adatok_lista)

forras.close()

cel = open("uj-adatlista.txt", "w", encoding="utf-8")

for nev in adatok_lista:
    print(nev, file=cel)

forras = open("adatok.txt", encoding="utf-8")

def f_kereso(adatok_lista):
    f_lista = []
    for f in adatok_lista:
        if f[2] == "F":
            f_lista.append(adatok_lista)
    return f_lista

f_lista = f_kereso(adatok_lista)
print(f_lista)

cel = open("uj-adatlista.txt", "w", encoding="utf-8")

for f in adatok_lista:
    print(f, file=cel)

# for nev in adatok_lista:
#     if nev in adatok_lista = "F":
#         print(nev)