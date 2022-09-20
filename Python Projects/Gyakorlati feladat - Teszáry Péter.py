#Teszáry Péter

import datetime
print('\t', "Tas, Ond és Álmos utazása", '\n', datetime.date.today())

karakterlanc= input("Kérek egy karakterláncot: ")
print(25 * karakterlanc)

tas= int(input("Mennyi pénze van Tasnak? "))
ond= int(input("Mennyi pénze van Ondnak? "))
almos= int(input("Mennyi pénze van Álmosnak? "))

print("\n")

print("Tasnak", tas, "forintja van, amely", tas // 400, "eurónak felel meg!")
print("Ondnak", ond, "forintja van, amely", ond // 400, "eurónak felel meg!")
print("Álmosnak", almos, "forintja van, amely", almos // 400, "eurónak felel meg!" "\n")

forint = int(tas) + int(ond) + int(almos)

euro = forint // 400

print("A fiúknak összesen: ", forint, "forintja van, amely", euro, "eurónak felel meg!" "\n")

lezaras = int(input("Kérek egy számot a lezáráshoz: "))
print("*_*" * lezaras)
