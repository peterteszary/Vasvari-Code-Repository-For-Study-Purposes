# Teszáry Péter - Mikulás dolgozat
# Itt tárolom az egyes tagság alapértékeit
zoldfulu = "Zöldfülű"
zoldfulu_tagdij = 20000
junior = "Junior"
junior_tagdij = 10000
halado = "Haladó"
halado_tagdij = 7000
senior = "Senior"
senior_tagdij = 4000

#Itt hozom létre a függvényt amit majd meghívok
def getMikulas(szakalhossz):
    if szakalhossz <= 10:
        return print("Az ön titulusa:", zoldfulu, "Az ön tagdjía", zoldfulu_tagdij, "Ft.")
    if szakalhossz <= 30:
        return print("Az ön titulusa:", junior, "Az ön tagdjía", junior_tagdij, "Ft.")
    if szakalhossz <= 50:
        return print("Az ön titulusa:", halado, "Az ön tagdjía", halado_tagdij, "Ft.")
    if szakalhossz <= 100:
        return print("Az ön titulusa:", senior, "Az ön tagdjía", senior_tagdij, "Ft.")

#Itt a While loopban van egy olyan kitétel, hogy ha a felhasználó által megadott érték nem szám, akkor jelezze a hibát.
while True:
    szakalhossz = input("Kérem adja meg a szakáll hosszát cm-ben: ")
    if szakalhossz.isnumeric():
        szakalhossz = int(szakalhossz)
        getMikulas(szakalhossz)
    else:
        print("Csak számot lehet megadni!")

    if (szakalhossz == 0):
        break

