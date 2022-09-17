budget = input("Mennyi pénze van összesen? ") #bekérem az adatokat
friends = input("Hány ismerősének szeretne ajándékot venni? ") #bekérem az adatokat
eredmeny = int(budget) // int(friends)
print("Önnek", eredmeny, "forint összeg jut egy fő ajándékára", )



import datetime
nev = "Teszáry Péter"
osztaly = "1/13b."
print("Név: ", nev, "Osztály: ", osztaly, "Dátum: ", datetime.date.today())
print(25*"-")