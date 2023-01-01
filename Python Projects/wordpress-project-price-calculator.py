zoldfulu = "Zöldfülű"
zoldfulu_tagdij = 20000
junior = "Junior"
junior_tagdij = 10000
halado = "Haladó"
halado_tagdij = 7000
senior = "Senior"
senior_tagdij = 4000

def getMikulas(szakalhosszak):
   szakalhosszak.sort()
   legnagyobbhossz = szakalhosszak[-1]

   if legnagyobbhossz <= 10:
      return print("Az ön titulusa:", zoldfulu, "Az ön tagdjía", zoldfulu_tagdij, "Ft.")
   if legnagyobbhossz <= 30 :
      return print("Az ön titulusa:", junior, "Az ön tagdjía", junior_tagdij, "Ft.")
   if legnagyobbhossz <= 50 :
      return print("Az ön titulusa:", halado, "Az ön tagdjía", halado_tagdij, "Ft.")
   if legnagyobbhossz <= 100:
      return print("Az ön titulusa:", senior, "Az ön tagdjía", senior_tagdij, "Ft.")
   #if legnagyobbhossz >= 101:
    #  return print("Az ön szakálla túl hosszú, kérem vágjon le belőle!")

szakalhosszak = []
while True:
   szakallhossz = input("Kérem adja meg a szakáll hosszát cm-ben: ")
   szakallhossz = int(szakallhossz)
   szakalhosszak.append(szakallhossz);
   getMikulas(szakalhosszak);
   if (szakallhossz == 0):
      break
getMikulas(szakalhosszak);