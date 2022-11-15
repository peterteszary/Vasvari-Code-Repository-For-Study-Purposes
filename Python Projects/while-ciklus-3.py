#Írjon programot, ami kiírja az első száz pozitív egész szám kétszeresét, emeljük négyzetre is!
# 1 2
# 2 4

szam = 1
while szam < 101:
    print( szam, szam *2, szam ** 2, sep = " - ")
    szam += 1
