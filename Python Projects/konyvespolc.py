# Házi könyvtár program - Teszáry Péter
# sys modul importálása
import sys

# Ez a függvény lesz az első, amely lefut, amint a fő függvény végrehajtódik
def alapkonyvtar():
    rows, cols = int(input("Kélek add meg a könyvek kezdeti darabszámát, tehát hogy hány db könyvet szeretnél felvinni: ")), 5

    # Bekérem a könyvek számát amit a felhasználó szeretne felvinni. Nulla is beírható, ha nem akarunk új tételt felvinni
    konyv = []
    print(konyv)
    for i in range(rows):
        print("\nKérlek add meg a(z) %d könyv adatait:" % (i + 1))
        print("FONTOS: a * jelölésű mezők kitöltése kötelező!")
        print("....................................................................")
        temp = []
        for j in range(cols):

        # A j értékei, csak a személyre szabott mezőkre

            if j == 0:
                temp.append(str(input("Könyv címe*: ")))

               #Itt bekerült egy biztosíték, hogy a felhasználó nem hagyta-e üresen a mezőt.

                if temp[j] == '' or temp[j] == ' ':
                    sys.exit(
                        "A cím kötelező mező. A folyamat megszakítása üresen hagyott mező miatt...")
            # Ez kilép a folyamatból, ha üres mezőt talál.

            if j == 1:
                temp.append(str(input("Add meg az ISBN számot: ")))
            # az ISBN számot string-ként kérem be, mert a betűt és számot egyaránt tartalmaz. Sok könyv nem rendelkezik ISBN számmal, mert régi, ezért nem kötelező mező.

            if j == 2:
                temp.append(str(input("Add meg a szerzőt: ")))
               # Ha ez a mező üresen marad, akkor sem kerül megszakításra a program.
                if temp[j] == '' or temp[j] == ' ':
                    temp[j] = None

            if j == 3:
                temp.append(str(input("Add meg a kiadás évét: ")))

                if temp[j] == '' or temp[j] == ' ':
                    temp[j] = None
            if j == 4:
                temp.append(
                    str(input("Add meg a műfajt: ")))
                if temp[j] == "" or temp[j] == ' ':
                    temp[j] = None

        konyv.append(temp)
    # Ezzel a lépéssel egy listát adunk hozzá a konyv listához
    # Ez azt jelenti, hogy a konyv egy 2D tömb, a temp pedig egy 1D tömb

    print(konyv)
    return konyv


def menu():
    # A menü csak híváskor fut le.
    print("----------------------------------------------------------")
    print("\t\t\tHÁZI KÖNYVTÁR", flush=False)
    print("----------------------------------------------------------")
    print("\tA következő műveletek hajthatóak végre a könyvtárban\n")
    print("1. Új könyv hozzáadása")
    print("2. Meglévő könyv törlése")
    print("3. Minden könyv törlése")
    print("4. Könyv keresése")
    print("5. Minden könyv megjelenítése")
    print("6. Kilépés a Házikönyvtárból")

    # A megadott 6 lehetőség közül a felhasználónak legalább egyet be kell írnia
    # A beírt választást esetünkben visszaadjuk a wiz main hívó függvénynek

    valasztas = int(input("Hanyas számú menüpontot választod: "))

    return valasztas


def add_konyv(pb):

    #Könyv adatainak bekérése

    dip = []
    for i in range(len(pb[0])):
        if i == 0:
            dip.append(str(input("Könyv címe: ")))
        if i == 1:
            dip.append(int(input("ISBN: ")))
        if i == 2:
            dip.append(str(input("Szerző: ")))
        if i == 3:
            dip.append(str(input("Kiadás éve: ")))
        if i == 4:
            dip.append(
                str(input("Műfaj: ")))
    pb.append(dip)

    # Ha a lista módosul, visszakerül a felhasználó a főmenübe.

    return pb


def meglevo_torlese(pb):

    # Ez a funkció törli az adott könyvet.

    query = str(
        input("Kérlek add meg a törölni kívánt könyv nevét: "))

    # Itt megnézzül létezik-e a könyv

    temp = 0

    # temp itt egy ellenőrző változó. Nulla értéket rendelünk hozzá.

    for i in range(len(pb)):
        if query == pb[i][0]:
            temp += 1

            # itt hozzáadunk egyet, tehát nem lesz többé figyelembe véve a funkció tekintetében.

            print(pb.pop(i))

            # A pop funkció törli az elemet

            print("A lekérdezés törlésre került")

            return pb
    if temp == 0:

        # Ha érvénytelek a keresés (mert az adott példány nem létezik), akkor is kap visszajelzést

        print("Sajnálom a kérésed érvénytelen.\
	Kérlek próbáld meg újra.")

        return pb


def osszes_torlese(pb):

    # Ez a funkció törli az összes könyvet, majd visszatér a menübe

    return pb.clear()


def meglevo_keresese(pb):

    # Ez a funkció megkeresi a létrező elemet, majd megjeleníti azt.

    valasztas = int(input("Kérlek add meg a keresési feltételeket:\n\n\
	1. Cím\n2. ISBN\n3. Szerző\n4. Kiadás éve\n5. Műfaj\
	\nKérlek add meg a kívánt keresési feltétel számát: "))

    # Ezt csak azért, hogy a preferált keresési feltétel alapján kereshessünk.

    temp = []
    check = -1

    if valasztas == 1:

        query = str(
            input("Kérlek add meg a keresendő könyv címét: "))
        for i in range(len(pb)):
            if query == pb[i][0]:
                check = i
                temp.append(pb[i])

    elif valasztas == 2:

        query = str(
            input("Kérlek add meg a keresendő könyv ISBN számát: "))
        for i in range(len(pb)):
            if query == pb[i][1]:
                check = i
                temp.append(pb[i])

    elif valasztas == 3:

        query = str(input("Kérlek add meg a keresendő szerző nevét: "))
        for i in range(len(pb)):
            if query == pb[i][2]:
                check = i
                temp.append(pb[i])

    elif valasztas == 4:

        query = str(input("Kérlek add meg az ISBN számot: "))
        for i in range(len(pb)):
            if query == pb[i][3]:
                check = i
                temp.append(pb[i])

    elif valasztas == 5:

        query = str(
            input("Kérlek, add meg a keresni kívánt könyv kategóriáját: "))
        for i in range(len(pb)):
            if query == pb[i][4]:
                check = i
                temp.append(pb[i])

    # A lekérdezés kategóriában lévő összes könyv megjelenik ezzel a funkcióval

    else:

        # Ha a felhasználó bármilyen más lehetőséget ad meg, a keresés sikertelen lesz

        print("Helytelen keresési kritérium")
        return -1
    # A -1 visszaadása jelzi, hogy nem jó a keresés feltétele


    if check == -1:
        return -1

    # A -1 jlezi, hogy a keresett elem nem található

    else:
        osszes_mutatasa(temp)
        return check


# Az összes könyv mutatása
def osszes_mutatasa(pb):
    if not pb:

       # Ha üres a lista, akkor is van visszajelzés

        print("A lista üres: []")
    else:
        for i in range(len(pb)):
            print(pb[i])


def koszi():

    # A kilépéskor egy elköszönés, hogy kerek legyen a történet

    print("----------------------------------------------------------")
    print("Köszönöm, hogy a Házikönyvtárat választottad.")
    print("Használd máskor is!")
    print("----------------------------------------------------------")
    sys.exit("Szia!")


# A Fő funkció kódja

print("----------------------------------------------------------")
print("Üdv Kedves Felhasználó a Házikönyvtárban!")
print("----------------------------------------------------------")

ch = 1
pb = alapkonyvtar()
while ch in (1, 2, 3, 4, 5):
    ch = menu()
    if ch == 1:
        pb = add_konyv(pb)
    elif ch == 2:
        pb = meglevo_torlese(pb)
    elif ch == 3:
        pb = osszes_torlese(pb)
    elif ch == 4:
        d = meglevo_keresese(pb)
        if d == -1:
            print("A könyv nem létezik. Kérlek próbáld újra")
    elif ch == 5:
        osszes_mutatasa(pb)
    else:
        koszi()
