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
        homlokzatnegyzetmeter = int(input("Hány négyzetméter a homlokzat? "))
    ragaszto = input("Ragasztó (25kg)? i/n ")
    dubel = input("Dűbel (250db/csomag)? i/n ")
    halo = input("Háló (250db/csomag)? i/n ")