# Ez a program egy árajánlat készítéséhez nyújt segítséget
# A program adatokat és információkat kér be, hogy ezáltal viszonylag pontos kalkulációt tudjon adni.

# Ide veszem fel a komponensek árait.

figma_design_terv = 150000
wp_keretrendszer = 15000
woo_keretrendszer = 15000
webshop_kapcsolodo_oldalak_letrehozasa = 75000
fizetesi_mod_integracio = 15000
oldal_letrehozas = 2500
bejegyzesek_feltoltese = 2500
mobiloptimalizalas = 50000
oldalbiztonsag = 30000
technikai_seo = 75000
google_analytics_integralas = 15000
google_search_console_integralas = 15000
termek_feltoltes = 2500
oldal_elesites = 20000

# Itt indítom el a folyamatot a megadott információk alapján.

def getWPInfo(wp_oldal):
    print("Ön WordPress weboldalt választott!")

def getWooInfo(woo_oldal):
    print("Woo oldalt wálasztott!")

print("Üdvözlöm az ajánlatadó alkalmazásban!")
print("A kalkulációt az Ön által megadott információk alapján fogja a kalkulátor kiszámítani.")
wp_oldal = input("Weboldalat vagy Webshop-ot szeretne fejlesztetni? o/s ")
if wp_oldal == "o":
    getWPInfo
if wp_oldal == "s":
    getWooInfo


