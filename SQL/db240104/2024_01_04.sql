-- 0: minden mindennel összekötve
-- A)
SELECT
*
FROM
    befiz, ugyfel
WHERE
    befiz.azon = ugyfel.azon
-- B)
SELECT * FROM befiz INNER JOIN ugyfel ON befiz.azon = ugyfel.azon
WHERE ...
GROUP BY ...
HAVING ...
ORDER BY ...
LIMIT ...
-- 1:  Hogy hívják az egyes ügyfeleket? Jelenítse meg a nevüket ABC-sorrendben! Megoldás...

-- 2:  Listázza ki a magyarországi ügyfeleket életkoruk szerint! Kezdje a legfiatalabbal!  Megoldás...

-- 3:  Adja meg a Pest megyei ügyfeleket! (Irányítószámuk 2-vel kezdődik.) Megoldás...

-- 4:  Mennyi pénzt fizettek be összesen az ügyfelek?

-- 5:  Mekkora összegű egy átlagos befizetés?

-- 6:  Mennyi volt az eddigi legkisebb illetve legnagyobb befizetett összeg? Megoldás...

-- 7:  Hány darab befizetés szerepel a nyilvántartásban?

-- 8:  Milyen összegeket, és mikor fizetett Török Bálint? 
SELECT befiz.osszeg, befiz.datum AS 'mikor' 
FROM befiz INNER JOIN ugyfel ON befiz.azon = ugyfel.azon
WHERE ugyfel.nev = "Török Bálint"

-- 9:  Mennyit fizetett összesen Nagy Károly?
SELECT SUM(befiz.osszeg) AS 'osszesen'
FROM befiz INNER JOIN ugyfel ON befiz.azon = ugyfel.azon
WHERE ugyfel.nev = "Nagy Károly"

-- 10:  Mennyit fizettek összesen a nem magyarországi befizetők?
SELECT SUM(befiz.osszeg) AS 'osszesen'
FROM befiz INNER JOIN ugyfel ON befiz.azon = ugyfel.azon
WHERE ugyfel.orsz != "H"

-- 11:  Mennyit fizettek az egyes ügyfelek? Megoldás...
-- A) mindenki
SELECT ugyfel.nev AS 'ugyfel', SUM(befiz.osszeg) AS 'osszesen'
FROM befiz RIGHT JOIN ugyfel ON befiz.azon = ugyfel.azon
GROUP BY ugyfel.azon
-- B) csak a fizeto ugyfelek
SELECT ugyfel.nev AS 'ugyfel', SUM(befiz.osszeg) AS 'osszesen'
FROM befiz INNER JOIN ugyfel ON befiz.azon = ugyfel.azon
GROUP BY befiz.azon
-- C) olyan mint B, csak NULL helyett 0-t ír
SELECT ugyfel.nev AS 'ugyfel', SUM(IF(befiz.osszeg IS NULL, 0, befiz.osszeg)) AS 'osszesen'
FROM befiz RIGHT JOIN ugyfel ON befiz.azon = ugyfel.azon
GROUP BY ugyfel.azon

-- 12:  Mi az első három legtöbbet befizető ügyfél sorrendje? Megoldás...

-- mire gondolt a költő?
-- A) össz-befizetésre?
SELECT ugyfel.nev AS `ugyfel`, SUM(befiz.osszeg) AS `osszesen`
FROM befiz INNER JOIN ugyfel ON befiz.azon = ugyfel.azon
GROUP BY befiz.azon
ORDER BY `osszesen` DESC
LIMIT 3
-- B) egy-egy befizetésre? (Ugyanaz a név többször is benne lehet a top3-ban)
SELECT ugyfel.nev AS 'ugyfel', befiz.osszeg AS 'egy_adott_befizetes'
FROM befiz INNER JOIN ugyfel ON befiz.azon = ugyfel.azon
ORDER BY 'egy_adott_befizetes' DESC
LIMIT 3
-- C) minden ügyfélnél megnézzük, mi volt a legnagyobb befizetése?
SELECT ugyfel.nev AS 'ugyfel', MAX(befiz.osszeg) AS 'alegnagyobb'
FROM befiz INNER JOIN ugyfel ON befiz.azon = ugyfel.azon
GROUP BY befiz.azon
ORDER BY 'osszesen' DESC
LIMIT 3
-- 13:  Mekkora összegű befizetések történtek az év egyes hónapjaiban?  Megoldás...
-- A)
SELECT 
    befiz.datum;
    YEAR(befiz.datum),
    MONTH(befiz.datum);
    -- szövegkezelő fgv.-ek:
    -- SUBSTR(miből, hányadik_betűtől, hány_darab)
    -- (az indexelés 1-től kezdődik)
    SUBSTR(befiz.datum, 1, 7) -- pl.: "2016-01"
    ,SUBSTR(befiz.datum, 3)
FROM `befiz` WHERE 1;    

-- B)

SELECT 
    CONCAT(
        YEAR(befiz.datum),
        ". ", 
        MONTH(befiz.datum),
        "."
        ) AS `ev_adott_honapja`,
    SUM(befiz.osszeg) AS `osszesen`
FROM
    befiz
GROUP BY YEAR(befiz.datum), MONTH(befiz.datum)
-- ha az adott csoportosításban több feltételt is felsorolunk, akkor az egy csoportba kerülő sorokra az a jellemző, hogy az adott csoporton belül minden felsorolt feltétel szerint egyeznek. pl. "2016-03-04 ..." és "2016-03-07" ... ugyan abba a csoportba kerülnek mert az és is és a hónap is egyezik náluk

ORDER BY YEAR(befiz.datum), MONTH(befiz.datum)        

-- C)

SELECT 
    SUBSTR(befiz.datum, 1, 7) AS `ev_adott_honapja`,
    SUM(befiz.osszeg) AS `osszesen`
FROM
    befiz
GROUP BY `ev_adott_honapja`
ORDER BY `ev_adott_honapja`
 



-- 14:  Melyek azok a napok, amikor több befizetés is történt?

-- 15:  Mely befizetések régebbiek egy évnél?  Megoldás...

-- hard mode: minden dátumhoz adjunk hozáá 7-et (hogy 2023 legyen).
UPDATE befiz
SET befiz.datum = DATE_ADD(befiz.datum, INTERVAL 7 YEAR)

-- B)
SELECT
    befiz.osszeg,
    befiz.datum AS 'befizretes_idopontja',
    DATE_ADD(NOW(), INTERVAL -1 YEAR) AS 'egy_evvel_ezelott'
FROM
    befiz
HAVING
    'befizetes_idopontja' < 'egy_evvel_ezelott'

-- 16:  Mennyi pénzt fizettek be az elmúlt 365 napban?

SELECT
SUM(befiz.osszeg) AS 'osszesen'
FROM
    befiz
WHERE DATE(befiz.datum) >= DATE_ADD( DATE (NOW()) , INTERVAL -365 DAY)

-- 17:  Ki a legidősebb ügyfél?

-- 18:  Ki, és mikor követte el a legkisebb összegű befizetést?

-- 19:  Kinek a legkevesebb az összes befizetése?

-- 20:  Van-e olyan ügyfél, aki még egyáltalán nem fizetett?  Megoldás...

-- 21:  Fejenként mennyit fizettek átlagosan az ügyfelek, ha az átlagba csak a fizető ügyfelek számítanak?  Megoldás...

-- 22:  Fejenként mennyit fizettek átlagosan az ügyfelek a nemfizető ügyfeleket is beszámítva? Megoldás...

-- 23:  Kik azok az ügyfelek, akik az átlagosnál többet fizettek?  Megoldás...
