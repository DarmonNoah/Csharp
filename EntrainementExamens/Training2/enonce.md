# Système de Génération de Contrats d'Assurance

---

Une compagnie d'assurance doit générer un grand nombre de contrats d'assurance. Chaque contrat contient :

- Des clauses standard (identiques pour tous les contrats d'un même type)
- Des informations personnalisées (nom du client, dates, montants)
- Des annexes spécifiques

Il existe trois types de contrats de base :

- Assurance Habitation
- Assurance Automobile
- Assurance Vie

Chaque contrat de base sert de modèle et peut être personnalisé pour créer des versions spécifiques aux clients. La création d'un nouveau contrat à partir de zéro est coûteuse en ressources car elle nécessite de charger toutes les clauses standard et de formater le document. De plus, certains clients souhaitent avoir plusieurs versions d'un même contrat avec des variations mineures (différentes franchises, différentes options).

Questions :

1. Quel pattern de conception permettrait de créer efficacement de nouveaux contrats en évitant de recréer entièrement chaque contrat à partir de zéro ?

2. Modélisez la solution à l'aide d'un diagramme de classes UML qui devra inclure :

   - La structure des contrats
   - Le mécanisme de création de nouveaux contrats
   - Les relations entre les différentes classes

3. Proposez une implémentation en C# du diagramme de classes qui devra permettre de :

   - Créer un contrat de base
   - Copier un contrat existant
   - Personnaliser les informations d'un contrat

4. Comment votre solution permettrait-elle de gérer efficacement :
   - La création de multiples versions d'un même contrat
   - L'ajout d'un nouveau type de contrat
   - La modification des clauses standard
