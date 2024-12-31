# Aide

Le pattern Adapter agit comme un traducteur entre deux parties qui ne peuvent pas communiquer directement, comme un adaptateur de prise électrique.

Son but principal est de faire fonctionner ensemble deux interfaces incompatibles. Par exemple :

- Vous avez une classe existante qui fonctionne bien, mais son interface ne correspond pas à ce dont vous avez besoin
- Vous voulez utiliser une bibliothèque externe, mais ses méthodes ont des noms différents de ceux attendus dans votre code

L'Adapter enveloppe un objet dans une nouvelle interface, traduisant les appels de méthodes d'un format à l'autre.
C'est comme avoir un interprète qui traduit une conversation entre deux personnes parlant des langues différentes.

Exemple concret : Imaginez que votre application utilise une méthode "envoyerMessage()",
mais la bibliothèque externe que vous voulez utiliser a une méthode "transmit()".
L'Adapter va faire le pont entre les deux en convertissant "envoyerMessage()" en "transmit()".
