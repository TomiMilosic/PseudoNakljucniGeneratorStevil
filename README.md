# Psevdo-naključni generatorji števil

Navodila naloge:

Izdelajte program za generiranje psevdo-naključnih števil.
Pri tem je potrebno implementirati vsaj dva različna algoritma za generiranje sekvence psevdo-naključnih števil (npr. z uporabo kotnih funkcij ali pa t. i. saw funkcij).
Algoritem za generiranje, ki bo temeljil na matematični funkciji, ki so jo boste zamislili, morate implementirati sami. 

Matematična funkcija mora vsebovati seme (seed), ki ga lahko avtomatsko generirate na podlagi trenutnega časa in datuma, premikov miške oz. časa med kliki, in podobno.
Seme T je pomembno zato, da program ne bo vedno znova generiral iste sekvence psevdo-naključnih števil. Matematična funkcija vsebuje tudi spremenljivko x1,
ki jo za prvo iteracijo določi (vpiše) uporabnik, izhod oz. rezultat funkcije y1 pa potem postane vhod v novo iteracijo in se uporabi namesto spremenljivke x2.
Na ta način lahko funkcija generira poljubno mnogo psevdo-naključnih števil.

V okviru naloge izdelajte aplikacijo, ki vključuje naslednje funkcionalnosti:

Izbira algoritma za generiranje psevdo-naključnih števil (kotna funkcija, saw funkcija,...),
Bonus: implementacija zahtevnejšega algoritma za generiranje psevdo-naključnih števil.
Implementacija matematične funkcije, ki vsebuje parametre y(x), x in T. 
Možnost generiranja naslednjega (realnega) psevdo-naključnega števila,
Možnost generiranja naslednjih 10, 100, 1.000, 10.000, oz. poljuben nabor psevdo-naključnih števil,
Zapisovanje generiranih števil v tekstovno datoteko,
Risanje grafa frekvenčne porazdelitve generiranih števil.


Primer programa: 
https://imgur.com/sJceotf 
