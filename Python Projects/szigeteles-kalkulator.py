#Ez a program, kiszámolja a homlokzat szigetelésének anyagköltségét.
#Azért ilyen kalkulátort készítettem, mert a beadandóm késedelmének és elmaradásának oka is ez volt. Mivel a feleségemmel ketten szigeteljük a házat, ezért próbálunk még a fagyok beállta előtt végezni.

#Az anyagok ára:
hungarocell_ar = 2500
ragaszto_ar = 2000
dubel_ar = 250
halo_ar = 1500

print("Üdvözlöm a homlokzat szigetelés kalkulátorban!")
print("Kérem az árkalkulációhoz válaszoljon a következő kérdésekre:")

leszhomlokzat = input("Lesz-e a homlokzat szigetelve? i/n: ")
if leszhomlokzat == "i":
    homlokzatnegyzetmeter = int(input("Hány négyzetméter a homlokzat? "))

leszlabazat = input("Lesz-e a lábazat szigetelve? i/n: ")
if leszlabazat == "i":
    labazatnegyzetmeter = int(input("Hány négyzetméter a lábazat? "))

if leszlabazat == "n" and leszhomlokzat == "n":
    print("Nincs mi alapján kiszámolni az anyagárat! Kérem próbálkozzon újra!")

else :
    print("Kérem adja meg mire van szüksége: ")
    hungarocell = input("Hungarocell? i/n ")
    if hungarocell == "i":
        print("Hozzáadtam a hungarocellt a kalkulációhoz")
    else :
        print("Rendben.")
    ragaszto = input("Ragasztó (25kg)? i/n ")
    if ragaszto == "i":
        print("Hozzáadtam a ragasztót a kalkulációhoz")
    else:
        print("Rendben.")

    dubel = input("Dűbel (250db/csomag)? i/n ")
    if dubel == "i":
        print("Hozzáadtam a dűbelt a kalkulációhoz")
    else:
        print("Rendben.")
    halo = input("Háló (20nm/csomag)? i/n ")
    if halo == "i":
        print("Hozzáadtam a hálót a kalkulációhoz")
    else:
        print("Rendben.")

print("A következő kalkuláció készült: ")

hungarocell_ossz = (homlokzatnegyzetmeter + labazatnegyzetmeter) * hungarocell_ar
ragaszto_ossz = (homlokzatnegyzetmeter + labazatnegyzetmeter) * ragaszto_ar
dubel_ossz = (homlokzatnegyzetmeter + labazatnegyzetmeter) * dubel_ar
halo_ossz = (homlokzatnegyzetmeter + labazatnegyzetmeter) * halo_ar

mindossz = hungarocell_ossz + ragaszto_ossz + dubel_ossz + halo_ossz

print("A hungarocell ára: " ,hungarocell_ossz, "Ft.")
print("A ragasztó ára: " ,ragaszto_ossz, "Ft.")
print("A dűbel ára: " ,dubel_ossz, "Ft.")
print("A háló ára: " ,ragaszto_ossz, "Ft.")

print("Mindösszesen: ", mindossz, "Ft.")

rendeles = input("Megrendeli a kalkulációban szereplő tételeket? i/n: ")
if rendeles == "i":
    print ("A rendelését rögzítettük " '\U0001F603')
else :
    print("Köszönjük, hogy nálunk érdeklődött!")