Die Keinidee ist 
Du hast viele Objekte mit gleichem, gemeinsamem Zustand (z. B. Marke, Modell, Farbe),

aber jedes Objekt hat auch einzigartige Eigenschaften (z. B. Nummernschild, Besitzer).

Anstatt jedes Mal ein neues, komplettes Objekt zu erstellen, speicherst man den gemeinsamen Teil nur einmal – und nutzt ihn mehrfach. Dadurch sparst man RAM.

Hier ein Beispiel

Man betreibst ein Lager für Spielzeugautos.

Ohne Flyweight:

Man bestellst für jeden Kunden ein komplett neues Auto – auch wenn es 100x der gleiche rote BMW ist.

Mit Flyweight:

Man lagert einmal den roten BMW ein.

Wenn ein Kunde ihn will, packst man den gleichen Autotyp ein, schreibst aber seinen Namen und sein Nummernschild aussen drauf.

Man hat also :

Gemeinsamer Zustand (Flyweight): BMW M5, rot

Einzigartiger Zustand (extrinsisch): Besitzer = „James Doe“, Nummer = „CL234IR“

