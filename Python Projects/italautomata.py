
valasztas = 0
darabszam = 1
osszesen = valasztas + darabszam
cola = "C"
narancsle = "N"
rostos = "R"
Kilepes = "E"

italok = [260, 290, 330]
betuk = ['C' , 'N' , 'R', 'E']

italok[0] = betuk[0]
italok[1] = "N"
italok[2] = "R"


print(italok)
print(betuk)

print("Válasszon a tételek közül: ")
print("C - Cola (260 Ft)")
print("N - Narancslé (290 Ft)")
print("R - Rostos üdítő (330 Ft)")
print("E - Kilépés")
input("Választás: ")
input("Darabszám: ")


print

if valasztas == "C":
    valasztas * darabszam
    print(osszesen)
if valasztas == "N":
    valasztas * darabszam
    print(osszesen)