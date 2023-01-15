forras = open("lajharok.txt","r", encoding="utf8")
lajharok = []
for sor in forras:
    sor = sor.strip()
    sor2 = forras.readline().strip()
    sor3 = forras.readline().strip()
    adat = (sor + ";" + sor2 + ";"+sor3)
    adat = adat.split(";")
    lajharok.append(adat)
print(lajharok)

forras.close()

print("A lajhárok száma: ", len(lajharok))

#nőstény és hím lajhárok száma

nemek = [nem[3] for nem in lajharok]
print(nemek)
no_db = 0
him_db = 0
for nem in nemek:
    if nem == "nosteny":
        no_db += 1
    elif nem == "him":
        him_db += 1

print("A hímek száma: ", him_db, nemek.count("him"))
print("Nőstények száma: ", no_db, nemek.count("nosteny"))

#listát hozunk létre a hímek és a nöstények
nostenyek =  []
himek =  []

for m in lajharok:
    if m [3] == "nosteny":
        nostenyek.append(m)
    if m [3] == "him":
        himek.append(m)
print(himek)
print(nostenyek)

# himek és nőstények adatainak kiírása fájlba nostenyek.txt - szóközzel elválasztva egy sorban, himek.txt,pontosvesszővel elválasztva egy sorban

nostenyfajl = open("nostenyek.txt", "w",encoding="utf8")
print(nostenyek)
for adat in nostenyek:
    print(",".join(adat), file = nostenyfajl)
nostenyfajl.close()

himfajl = open("himek.txt", "w", encoding="utf8")

for adat in himek:
    print(";".join(adat), file=himfajl)
himfajl.close()

print(nemek)
nemekfájl = open("nem.txt","w", encoding="utf8")

for i in nemek:
    sor = i + "; "
    print(sor, file = nemekfájl)