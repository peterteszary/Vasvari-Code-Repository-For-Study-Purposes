adatok = []
atlag = []

forras = open("sebesseg.txt")

for sor in forras:
    sor = sor.strip().split()
    sor = list(map(int, sor))
    adatok.append(sor)
print(adatok)

#Hány autó adatát rögzítették?
print(len(adatok)," autó adatát rögzítették.")

for i in adatok:
    v_atlag = round(sum(i)/len(i),2)
    atlag.append(v_atlag)

print(atlag)
# A legnagyobb átlagsebességű autó
max_atlag = max(atlag)
print("A(z)", str(atlag.index(max_atlag)+1),". autó átlagsebessége volt a legnagyobb: ", max_atlag)

for i in range(len(atlag)):
    print("Az", i+1, ". autó legnagyobb sebessége", atlag[i], "km/h")

forras.close()

cel = open("atlagsebesseg.txt", "w")

for i in range(len(atlag)):
    cel.write(str(i+1) + " " + str(atlag[i]) + "\n")
    cel.write("\n2023\n")