# elma

Ein Pacman-inspiriertes Spiel erstellt auf der Basis von Unity.

Aktueller Stand:
* Spielbrett erstellt
* Kapseln werden von Dummy-Pacman gefressen
* Ein dummy Geist, der nichts tut
* Kollisionsverhalten, wird voraussichtlich auf NavMesh Basis umgesetzt,
  aktuell über RigidBody, Kintetic und Skript behandelt

Future work:
* Es ist nicht möglich den NavMesh zur Laufzeit zu generieren.
Das verhindert dynamisches Kreieren der Welt mit vertretbarem Aufwand
Mit Unity 5.6 soll die möglich werden: https://github.com/Unity-Technologies/NavMeshComponents
Allerdings konzentriert sich das Projekt auf Unity 5.5