# Levesek
print ("Levesek (1 adag)")
print("Kérem válasszon leveskínálatunkból: i / ENTER \n")
# "Frankfurti leves: 550 Ft / adag"
# "Zöldségleves: 400 Ft / adag"
# "Gyümölcsleves: 300 Ft / adag"

print("\nLevesek: ")

#Leves(ek) kiválasztása (sp)
#sp_ = soup (leves), m_= main (főétel), po_ = pottage (főzelék), sd_ = side (köret)
sp_A = bool(input("Frankfurti leves: "))
pr_sp_A = 550
sp_B = bool(input("Zöldségleves: "))
pr_sp_B = 400
sp_C = bool(input("Gyümölcsleves: "))
pr_sp_C = 300

print ("Választott leves(ek):")
if sp_A:
    sp = "Frankfurti"
    pr_sp = pr_sp_A
    if sp_B:
        sp = "Frankfurtileves, zöldségleves"
        pr_sp = pr_sp_A + pr_sp_B
        print(sp, "Fizetendő:", sp_pr)
        if sp_C:
            sp = "Frankfurti-, zöldség- és gyümölcsleves"
            pr_sp = pr_sp_A + pr_sp_B + pr_sp_C
            print(sp, "Fizetendő:", pr_sp)
    else:
        print(sp, "Fizetendő:", pr_sp)


elif sp_B:
    sp = "Zöldségleves"
    pr_sp = pr_sp_B
    if sp_gyumolcsleves:
        sp = "Zöldség- és gyümölcsleves"
        pr_sp= pr_sp_B + pr_sp_C
        print(sp, "Fizetendő:", pr_sp)
    else:
        print(sp, "Fizetendő:", pr_sp)

elif sp_C:
    sp = "Gyümölcsleves"
    pr_sp = pr_sp_C
    print(sp, "Fizetendő:", pr_sp)

else:
    print ("Nem választott levest.")

# Főételek
print ("Főételek (1 adag)")
print("Kérem válasszon főételeinkből: i / ENTER \n")
print("\nFőételek: ")

#Főétel(ek) kiválasztása (m)
m_A = bool(input("Szezámmagos csirkemell: "))
pr_m_A = 600
m_B = bool(input("Pizza szelet (2db): "))
pr_m_B = 550
m_C = bool(input("BBQ Csirkecomb: "))
pr_m_C = 550

print ("Választott főétel(ek):")
if m_A:
    m = "Szezámmagos csirkemell"
    pr_m = pr_m_A
    if m_B:
        m = "Szezámmagos csirkemell, Pizza szelet (2db)"
        pr_m = pr_m_A + pr_m_B
        print(m, "Fizetendő:", pr_m, "Ft")
        if m_C:
            m = "Szezámmagos csirkemell, Pizza szelet és BBQ Csirkecomb"
            pr_m= pr_m_A + pr_m_B + pr_m_C
            print(m, "Fizetendő:", pr_m, "Ft")
    else:
        print(m, "Fizetendő:", pr_m, "Ft")


elif m_B:
    m = "Pizza szelet (2db)"
    pr_m = pr_m_B
    if m_C:
        m = "Zöldség- és gyümölcsleves"
        pr_m= pr_m_B + pr_m_C
        print(m, "Fizetendő:", pr_m, "Ft")
    else:
        print(m, "Fizetendő:", pr_m, "Ft")

elif m_C:
    m = "BBQ csirkecomb"
    pr_m = pr_m_C
    print(m, "Fizetendő:", pr_m, "Ft")

else:
    print ("Nem választott főételt.")

#Főzelék(ek) kiválasztása (sd)
po_A = bool(input("Borsófőzelék: "))
pr_po_A = 200
po_B = bool(input("Finomfőzelék: "))
pr_po_B = 150
# po_C = bool(input("Szósz (Kentucky, Ketchup, BBQ): "))
# pr_po_C = 550

print ("Választott főzelék(ek):")
if po_A:
    po = "Borsófőzelék"
    pr_po = pr_po_A
    if po_B:
        po = "Borsófőzelék, Finomfőzelék"
        po_pr = pr_po_A + pr_po_B
        print(po, "Fizetendő:", pr_po, "Ft")
        if po_C:
            m = "Borsófőzelék, Finomfőzelék és Szósz (Kentucky, Ketchup, BBQ)"
            pr_po = pr_po_A + pr_po_B + pr_po_C
            print(po, "Fizetendő:", pr_po, "Ft")
    else:
        print(po, "Fizetendő:", pr_po, "Ft")


elif po_B:
    po = "Finomfőzelék"
    pr_po = pr_po_B
    if po_C:
        po = "Finomfőzelék- és Szósz (Kentucky, Ketchup, BBQ)"
        pr_po= pr_po_B + pr_po_C
        print(po, "Fizetendő:", pr_po, "Ft")
    else:
        print(po, "Fizetendő:", pr_po, "Ft")

# elif po_C:
#    m = "Szósz (Kentucky, Ketchup, BBQ)"
#    m_pr = pr_po_C
#    print(m, "Fizetendő:", pr_po, "Ft")
else:
    print ("Nem választott főzeléket.")



#Köret(ek) kiválasztása (sd)
sd_A = bool(input("Sültkrumpli: "))
pr_sd_A = 600
sd_B = bool(input("Rizs: "))
pr_sd_B = 550
sd_C = bool(input("Szósz (Kentucky, Ketchup, BBQ): "))
pr_sd_C = 550

print ("Választott Köret(ek):")
if sd_A:
    sd = "Sültkrumpli"
    pr_sd = pr_sd_A
    if sd_B:
        sd = "Sültkrumpli, Rizs"
        sd_pr = pr_sd_A + pr_sd_B
        print(sd, "Fizetendő:", pr_sd, "Ft")
        if sd_C:
            m = "Sültkrumpli, Rizs és Szósz (Kentucky, Ketchup, BBQ)"
            m_pr= pr_sd_A + pr_sd_B + pr_sd_C
            print(sd, "Fizetendő:", pr_sd, "Ft")
    else:
        print(sd, "Fizetendő:", pr_sd, "Ft")


elif sd_B:
    sd = "Rizs"
    pr_sd = pr_sd_B
    if sd_C:
        sd = "Rizs- és Szósz (Kentucky, Ketchup, BBQ)"
        pr_sd= pr_sd_B + pr_sd_C
        print(sd, "Fizetendő:", pr_sd, "Ft")
    else:
        print(sd, "Fizetendő:", pr_sd, "Ft")

elif sd_C:
    m = "Szósz (Kentucky, Ketchup, BBQ)"
    m_pr = pr_sd_C
    print(m, "Fizetendő:", pr_sd, "Ft")

else:
    print ("Nem választott köretet.")

pr_total = pr_sp + pr_m + pr_po + pr_sd

print ("Ön az alábbiakat választotta:")
print("Leves(ek):", sp)
print("Főétel(ek):", m)
print("Főzelék(ek):", po)
print("Köret(ek):", sd)
print("Fizetendő összesen: ", pr_total, "Ft")

# H-P Menü
if sp and m and sd:
    if sp_A and (m_A or m_B) and (sd_A or sd_C): #más étel nem választható hiányzik!
        print("H-P Menü")
    if (sp_A or sp_B) and ((m_C and sd_B) or (m_C and sd_B)):
        print("Hétvégi menü")


# Egyedi menü
# else: # az előző kettő után
        # print("Egyedi menü")

# Árvizsgálat <1500 Ft értékhatáron belül
if pr_total <= 1500:
        print("A menü a megadott értékhatáron belül van", pr_total)
else:
    print("A menü ára meghaladta a napi keretünket", pr_total)