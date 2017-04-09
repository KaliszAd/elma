# elma

Ein Pacman-inspiriertes Spiel erstellt auf der Basis von Unity.

Aktueller Stand:
* Ein Level, Verlieren wenn Berührung vom einem der vier Geister, Gewinn, wenn alle Kapsel gesammelt wurden
* Ausweichen wird durch schnellen Packman und Portale erleichtert

Future work:
* Bessere Geisterlogik
* Es ist nicht möglich den NavMesh zur Laufzeit zu generieren.
Das verhindert dynamisches Kreieren der Welt mit vertretbarem Aufwand
Mit Unity 5.6 soll die möglich werden: https://github.com/Unity-Technologies/NavMeshComponents
Allerdings konzentriert sich das Projekt auf Unity 5.5
* ggf. Steuerung verbessern, kann manchmal etwas "ruckeln", Gestaltung der Menüs gestalten
* Codestruktur eleganter gestalten, ingenieurtechnisch sauberer Entwurf
* HighScore-Liste
* Audio, Sounds an und ausmachen ggf. Lautstärke anpassen

Music:
"El Puffiachi", Written and performed by Manuel Jara and Mauricio Moreno of 'Los Morenos'.
https://www.openbsd.org/48.html

Texturen sind nach bestem Gewissen unter public domain Lizenz.

Sounds von Adam Kalisz.

Autoren und die Arbeiten:
* Elena Mulear
** Gestaltung der Geister, PacMan Figur

* Martin Sýkora
** Spielbrett inclusive Elemente
** Einiges an interner Logik vor allem Bewegung von PacMan
** Steuerung
** Minimap Ansatz
** Ansatz zur dynamischen Spielfeldgenerierung
** Ansatz zur Scorezählung
** Anfangstexturen
** Projektmanagement

* Adam Kalisz
** Bewegung und Navigation der Geister
** Portale, zusätzliche Texturen
** Spiel- und Menulogik
** Musik und Esseffekt
** Dokumentation, Repository-Verwaltung
** Minimap und Score überarbeitet
** HighScore
** Menüs, Eingabefelder, Audioeinstellungen