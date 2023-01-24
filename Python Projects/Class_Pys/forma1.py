import random

versenyzok = []

forras = open("pilotak.txt", encoding="utf-8")

# itt már két sort olvasok be, amit két változóban tárolok:
for sor in forras:
    sor = sor.strip() # sor beolvasása
    sor2 = forras.readline().strip() # 2. sor beolvasása | ha több sor van, akkor csak a második sortól kell a readline
    ossza_adat = sor + "," + sor2 # összefűzöm a két sort és egy új változóban tárolom
    ossza_adat = ossza_adat.split(",") # felülírom saját magával és hozzáfűzöm a vesszőket
    versenyzok.append(ossza_adat) # hozzáfűzöm a meglévő listához
#    print(versenyzok) # kiiratom a formázott listát


# a versenyzők száma
print("A versenyzők száma: ", len(versenyzok))

"""Írja ki a nyilvántartásban szereplő versenyzők neveit, szóközzel elválasztva a képernyőre és
írja ki a nevek.txt fájlba. Minden adat új sorba kerüljön."""
nevek = [i[1] for i in versenyzok]
print(nevek)
print( "A versenyzők nevei:", ", ".join(nevek))

#fájlba írás
forras.close()

cel = open("nevek.txt", "w", encoding="utf-8")

# ez egy sorba írja ki a fileba az adatokat
print(" ". join(nevek), file = cel)

#több sorba írja ki a fájlba
for nev in nevek:
    print(nev, file = cel)

veletlen = [i[0] for i in nevek]
print("Véletlenszerűen írjon ki egy versenyzőt: ", random.choice(veletlen))