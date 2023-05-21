Mobileum Absztrakt

Beadandó feladatom egy statikus weboldal elkészítése volt BootStrap CSS keretrendszerrel.
A feladatot a menüsor tervezésével kezdtem, ahol meghatároztam, milyen menüpontok lesznek. Így már láthatóvá vált, milyen oldalakra lesz szükség és azok nagyjából hogyan fognak kinézni. Elkezdtem ezzel kapcsolatban egy designtervet is készíteni, de aztán ezt hamar elvetettem, mert sok minden inkább a fejlesztés során alakult ki.

Többszöri nekifutára érte el az oldal a jelenlegi állapotát. Bár statikus oldalról van szó, de nem szerettem volna, ha egy menüpont módosítás miatt, minden HTML fájlban egyesével át kell írni az adott módosítást. Így hát modulárisan építettem fel az oldalt. A main-elements könyvtárban találhatóak a header és footer elemek. A sections könyvtárban pedig a főoldalon felhasznált kártyás elrendezések szekciói valamint a hero section. Ezeket JavaScript segítségével hívtam meg az adott helyre. Tehát csak egy rövidebb kódsort kellett elhelyeznem a header, footer és szekciók esetében is. Ez hívta meg az HTML fájl, ami pedig az adott rész elrendezését tartalmazza. Ez azért volt hasznosabb így, mert mindent csak egy helyen kell módosítani és minden oldal modulárisan épül fel, tehát ha egy elemet többször fel akarok használni, akkor az ezzel a módszerrel sokkal egyszerűbben megtehetem. Végeredményként pedig a kód is átláthatóbb.
A telefonok is külön mappát kaptak, mert szeretem, ha minden rendezett a háttérben. Ez feleslegesnek tűnhet, de hosszú távon egy nagyobb projekt esetén megkönnyíti a munkát.

Az oldal maga a mobiltelefonok története szempontjából közelíti meg a témát, ezért az oldalon is meghatároztam korszakokat, illetve kiemeltem néhány fontosabb telefont, például olyanokat amiket nekem is volt szerencsém használni.
A készülékekhez külön layout-ot készítettem amit minden készülék aloldalára alkalmaztam. Így azok egységesen tudnak megjelenni.

Hogy életszerű legyen az oldal, egy kapcsolati űrlapot is elhelyeztem a kapcsolat.html oldalon, amelyet JavaScript-el készítettem el. Ha elküldük az űrlapot, egy köszönő oldalra irányít minket.
A színek tekintetében a sötét háttér, világos betű párosítást preferáltam. Az oldal letisztult, jól áttekinthető és mobiloptimalizált, vagyis reszponzív.