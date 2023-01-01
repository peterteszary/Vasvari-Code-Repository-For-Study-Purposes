zoldfulu = "Zöldfülű"
zoldfulu_tagdij = 20000
junior = "Junior"
junior_tagdij = 10000
halado = "Haladó"
halado_tagdij = 7000
senior = "Senior"
senior_tagdij = 4000


szakallhossz = []

while True:
    hossz = input(int("Kérem adja meg a szakáll hosszát cm-ben: "))
    szakallhossz.append(hossz)

    if szakallhossz == 1 <= 10 :
        print("Az ön titulusa:", zoldfulu, "Az ön tagdjía", zoldfulu_tagdij, "Ft.")
    if szakallhossz == 11 <= 30 :
        print("Az ön titulusa:", junior, "Az ön tagdjía", junior_tagdij, "Ft.")
    if szakallhossz == 31 <= 50 :
        print("Az ön titulusa:", halado, "Az ön tagdjía", halado_tagdij, "Ft.")
    if szakallhossz == 51 <= 100:
        print("Az ön titulusa:", senior, "Az ön tagdjía", senior_tagdij, "Ft.")
    if szakallhossz == 0 :
        exit()
    else:
        print("Helytelen adat, kérem próbálja meg újra!")

