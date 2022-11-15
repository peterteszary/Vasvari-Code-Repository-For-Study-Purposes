# Ez a program, kiszámolja a homlokzat szigetelésének anyagköltségét.
# Azért ilyen kalkulátort készítettem, mert a beadandóm késedelmének és elmaradásának oka is ez volt.
# Ez elmúlt néhány hétben a feleségemmel ketten szigeteljük a házat, ezért próbálunk még a fagyok beállta előtt végezni.
# A szineket a szövegben innen "szereztem":
# https://stackoverflow.com/questions/287871/how-do-i-print-colored-text-to-the-terminal
# A kilépést pedig innen: https://stackoverflow.com/questions/48189978/python-if-else-exit

# Terminál betűszín:
class bcolors:
    WARNING = '\033[93m'
    ENDC = '\033[0m'
    OKGREEN = '\033[92m'
    OKBLUE = '\033[94m'


# Az anyagok ára:

hungarocell_ar = 2500
ragaszto_ar = 2000
dubel_ar = 250
halo_ar = 1500

# A bevezető rész:

print("Üdvözlöm a homlokzat szigetelés kalkulátorban!")
print("A kalkulációt az Ön által megadott négyzetméter alapján fogja a kalkulátor kiszámítani.")
print(bcolors.WARNING + "A homlokzat és lábazat szigetelés méretét négyzetméterben, külön kell megadni." + bcolors.ENDC)
print("Kérem az árkalkulációhoz válaszoljon a következő kérdésekre:")

# Itt kérem be, hogy mi lesz szigetelve:

leszhomlokzat = input("Lesz-e a homlokzat szigetelve? i/n: ")
if leszhomlokzat == "i":
    homlokzatnegyzetmeter = int(input("Hány négyzetméter a homlokzat? "))
else: homlokzatnegyzetmeter = 0

leszlabazat = input("Lesz-e a lábazat szigetelve? i/n: ")
if leszlabazat == "i":
    labazatnegyzetmeter = int(input("Hány négyzetméter a lábazat? "))
else: labazatnegyzetmeter = 0

if leszlabazat == "n" and leszhomlokzat == "n":
    print("Nincs mi alapján kiszámolni az anyagárat! Kérem próbálkozzon újra!")

# Itt kérem be, hogy mely anyagokra van szüksége:

else:
    print("Kérem adja meg mire van szüksége: ")

    hungarocell = input("Hungarocell? i/n ")
    if hungarocell == "i":
        print("Hozzáadtam a hungarocellt a kalkulációhoz")
    else:
        hungarocell_ar = 0
        print("Rendben. A Tétel nem kerül rögzítésre!")

    ragaszto = input("Ragasztó (25kg)? i/n ")
    if ragaszto == "i":
        print("Hozzáadtam a ragasztót a kalkulációhoz")
    else:
        ragaszto_ar = 0
        print("Rendben. A Tétel nem kerül rögzítésre!")

    dubel = input("Dűbel (250db/csomag)? i/n ")
    if dubel == "i":
        print("Hozzáadtam a dűbelt a kalkulációhoz")
    else:
        dubel_ar = 0
        print("Rendben. A Tétel nem kerül rögzítésre!")

    halo = input("Háló (20nm/csomag)? i/n ")
    if halo == "i":
        print("Hozzáadtam a hálót a kalkulációhoz")
    else:
        halo_ar = 0
        print("Rendben. A Tétel nem kerül rögzítésre!")

print("A következő kalkuláció készült: ")

# Itt készül a számítás:

hungarocell_ossz = (homlokzatnegyzetmeter + labazatnegyzetmeter) * hungarocell_ar
ragaszto_ossz = (homlokzatnegyzetmeter + labazatnegyzetmeter) * ragaszto_ar
dubel_ossz = (homlokzatnegyzetmeter + labazatnegyzetmeter) * dubel_ar
halo_ossz = (homlokzatnegyzetmeter + labazatnegyzetmeter) * halo_ar

mindossz = hungarocell_ossz + ragaszto_ossz + dubel_ossz + halo_ossz

# Tételesen:

print("A hungarocell ára: ", hungarocell_ossz, "Ft.")
print("A ragasztó ára: ", ragaszto_ossz, "Ft.")
print("A dűbel ára: ", dubel_ossz, "Ft.")
print("A háló ára: ", ragaszto_ossz, "Ft.")

print("Mindösszesen: ", mindossz, "Ft.")

# Ha esetleg sehol sem válaszolt igennel, akkor ezt jelzi illetve kilép a program.
# Ha valid válaszokat adott, akkor pedig dönthet, hogy megrendeli vagy sem.
# Ekkor is más-más üzenetet kap.

if mindossz == 0:
    print(bcolors.WARNING + "Nincs tétel a kalkulációban így nem lehet elkészíteni! A kalkulátor bezáródik!" + bcolors.ENDC)
    exit()
else:
    rendeles = input("Megrendeli a kalkulációban szereplő tételeket? i/n: ")
if rendeles == "i":
    print(bcolors.OKGREEN + "A rendelését rögzítettük " '\U0001F603' + bcolors.ENDC)
else:
    print(bcolors.OKBLUE + "Köszönjük, hogy nálunk érdeklődött!" + bcolors.ENDC)
