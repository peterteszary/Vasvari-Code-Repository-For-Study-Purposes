#Írj programot, ami megkérdi a felhasználótól, hogy hánytól-hányig írja ki a számokat (és aztán írd is ki őket)!
#Kérdezze meg azt is, hogy hányasávak írja ki a számokat a program!
#Kérdezze meg azt is, hogy hanyadik hatványokat tüntesse fel a szám mellett a program!

mettol = int(input("Kérem adja meg mettől szeretné kiíratni a számokat: "))
meddig = int(input("Kérem adja meg meddig szeretné kiíratni a számokat: "))
ugras = int(input("Kérem adja meg milyen ugrásokkal írjuk ki a számokat: "))
hatvany = int(input("Melyik hatványra emeljük a számokat: "))

while mettol <= meddig:
   # print(mettol, end = "; ")
    print(mettol, mettol ** hatvany)
    mettol += ugras

print("\nVége! ")