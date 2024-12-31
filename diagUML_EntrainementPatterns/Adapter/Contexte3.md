# Adapter

## Description

Le but du pattern Adapter est de convertir l’interface d’une classe existante en l’interface attendue par des clients également existants afin qu’ils puissent travailler ensemble. Il s’agit de conférer à une classe existante une nouvelle interface pour répondre aux besoins de clients.

## Contexte

Le serveur Web du système de vente de véhicules crée et gère des documents destinés aux clients. L’interface Document a été définie pour cette gestion. Sa représentation UML est montrée à la figure 10 ainsi que ses trois méthodes setContenu, dessine et imprime. Une première classe d’implantation de cette interface a été réalisée : la classe DocumentHtml qui implante ces trois méthodes. Des objets clients de cette interface et de cette classe ont été conçus.

Par la suite, l’ajout des documents PDF a posé un problème car ceux-ci sont plus complexes à construire et à gérer que des documents HTML. Un composant du marché a été choisi mais dont l’interface ne correspond à l’interface Document. La figure 10 montre le composant ComposantPdf dont l’interface introduit plus de méthodes et dont la convention de nommage est de surcroît différente (préfixe pdf).

Le pattern Adapter propose une solution qui consiste à créer la classe DocumentPdf implantant l’interface Document et possédant une association avec ComposantPdf. L’implantation des trois méthodes de l’interface Document consiste à déléguer correctement les appels au composant PDF. Cette solution est visible sur la figure 10, le code des méthodes étant détaillé à l’aide de notes.
