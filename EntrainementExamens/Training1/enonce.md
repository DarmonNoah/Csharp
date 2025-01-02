# Système de Production de Documents Bancaires

Une banque propose différents types de documents officiels à ses clients en fonction de leur statut (particulier ou professionnel) :
Les clients particuliers reçoivent :

Un relevé d'identité bancaire simplifié
Une attestation de compte standardisée

Les clients professionnels reçoivent :

Un relevé d'identité bancaire détaillé avec SIRET
Une attestation de compte avec mentions légales spécifiques

Chaque document doit être généré selon des normes strictes de sécurité et porter le logo de la banque, quelle que soit sa version (particulier ou professionnel).

## Questions :

### En utilisant le pattern Abstract Factory, modélisez la création des documents bancaires en fonction du type de client (particulier ou professionnel).

### Réalisez le diagramme de classes UML correspondant qui devra inclure :

- Les fabriques abstraite et concrètes
- Les produits abstraits (document bancaire) et leurs implémentations concrètes
- Les relations entre les différentes classes

### Proposez une implémentation en C# du diagramme de classes en vous concentrant sur :

- La structure des fabriques
- La création des différents types de documents
- Un exemple d'utilisation dans une méthode Main()

### Comment votre solution permettrait-elle d'ajouter facilement un nouveau type de document (par exemple une attestation fiscale) tout en respectant le principe Open/Closed ?
