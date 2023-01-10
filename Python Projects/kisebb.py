
# szam1 = 0
# szam2 = 0
# beadas = 0
# def kisebb(ertek):
#     if szam1 < szam2:
#         return "a kisebb érték "
#     elif szam1 > szam2:
#         return "a kisebb érték "
#     elif szam1 == szam2:
#         return "A két szam egyenlő"
#
# while beadas != "":
#     beadas = input("Adj meg egy számot! ")
#     if beadas == "":
#         break
#     beadas = int(beadas)
#     print(kisebb())

# Létrehozzuk a kisebb.py fájlt

# Bekérjük a felhasználótól az egyik számot, és tároljuk
num1 = input("Kérem az első számot: ")

# A bekért számot szám típusúvá alakítjuk
num1 = int(num1)

# A bekért számot tároljuk és szám típusúvá alakítjuk
num2 = int(input("Kérem a második számot: "))

# Elágazást használunk a különböző esetek kezelésére
if num1 > num2:
    print("Az első szám ", num1 , " nagyobb a másodiknál ", num2)
elif num1 < num2:
    print("A második szám ", num2 , " nagyobb az elsőnél ", num1)
else:
    print("A két szám egyenlő")

