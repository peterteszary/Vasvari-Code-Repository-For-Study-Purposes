#Teszáry Péter
# Bekérjük a felhasználótól az egyik számot, és tároljuk
szam1 = input("Kérem az első számot: ")

# A bekért számot szám típusúvá alakítjuk
szam1 = int(szam1)

# A bekért számot tároljuk és szám típusúvá alakítjuk
szam2 = int(input("Kérem a második számot: "))

# Elágazást használunk a különböző esetek kezelésére
if szam1 > szam2:
    print("A kisebb érték: ", szam2)
elif szam1 < szam2:
    print("A kisebb érték:  ", szam1)
else:
    print("A két szám egyenlő")

