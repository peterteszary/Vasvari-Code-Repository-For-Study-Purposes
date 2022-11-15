#Kérjünk be számokat a felhasználótól, 0 bemenetig, végjelig. Írjuk ki a bevitt számok darabszámát!

i = 0
szam = 1

while szam != 0:

    szam = int(input("Kérek egy számot: "))
    i = i + 1
    print("A bevitt számok száma: ", i)

print("\nA bevitt számok száma összesen: ", i)

