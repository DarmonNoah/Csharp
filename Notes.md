# Notes sur les Design Patterns

## 1. Introduction aux Design Patterns

### Qu'est-ce qu'un Design Pattern ?
- **Définition** : Un Design Pattern est un schéma d’objets qui propose une solution réutilisable à un problème récurrent.
- **Caractéristiques** :
  - Utilisé dans la programmation orientée objet (POO).
  - Basé sur des bonnes pratiques de conception.

### Classification des Patterns
- **Patterns de construction** : Gèrent la création des objets.
  - Exemple : Abstract Factory, Builder, Prototype, Singleton.
- **Patterns de structuration** : Organisent les hiérarchies et les relations entre les objets.
  - Exemple : Adapter, Bridge, Decorator.
- **Patterns comportementaux** : Gèrent la communication et la collaboration entre les objets.
  - Exemple : Chain of Responsibility, Command.

## 2. Patterns de Construction

### 2.1 Abstract Factory
- **But** : Créer des familles d'objets liés sans connaître les classes concrètes.
- **Avantages** :
  - Ajout facile de nouveaux types de produits.
  - Cohérence garantie entre les objets créés.
- **Exemple** : Création d’un catalogue de véhicules par type d’énergie (essence, électrique).
- **Domaines d'utilisation** :
  - Systèmes modulaires avec multiples variantes de produits.
  - Besoin de maintenir l'indépendance entre système et création des objets.

### 2.2 Builder
- **But** : Séparer la construction d’un objet complexe de sa représentation.
- **Caractéristiques** :
  - Permet une création étape par étape.
  - Masque la complexité au client.
- **Exemple** : Création de documents (HTML, PDF) pour des commandes.
- **Domaines d'utilisation** :
  - Objets avec de nombreux paramètres.
  - Différentes représentations pour un même objet.

### 2.3 Prototype
- **But** : Créer de nouveaux objets par duplication (clonage) d’objets existants.
- **Exemple** :
  - Créer une "liasse vierge" pour les ventes de véhicules.
  - Modification de la copie pour personnalisation.
- **Avantages** :
  - Simplifie la création d’objets complexes.
  - Réduit les coûts de création.
- **Domaines d'utilisation** :
  - Éditeurs graphiques (formes géométriques).
  - Jeux vidéo (variations d’ennemis).
  - Création d’objets systèmes coûteux (ex. connexions réseau).

### 2.4 Singleton
- **But** : Assurer qu’une classe ne possède qu’une seule instance.
- **Avantages** :
  - Point d’accès global.
  - Garantie d’unicé.
- **Domaines d'utilisation** :
  - Ressources partagées (connexion à une base de données).
  - Gestion de configurations globales.

## 3. Patterns de Structuration

### 3.1 Objectif
- **But** :
  - Encapsuler la composition des objets.
  - Faciliter l’indépendance entre interface et implémentation.
- **Avantages** :
  - Hiérarchies plus simples et maintenables.
  - Augmente le niveau d’abstraction.

### 3.2 Adapter
- **But** : Convertir l’interface d’une classe en une autre interface attendue par ses clients.
- **Exemple** :
  - Adapter une bibliothèque externe (ex. PDF) dans un système existant.
- **Domaines d'application** :
  - Intégration de librairies externes.
  - Compatibilité avec des systèmes existants.

### 3.3 Decorator
- **But** : Ajouter dynamiquement des fonctionnalités à un objet sans modifier son interface.
- **Exemple** :
  - Ajout de détails techniques pour des véhicules haut de gamme dans un catalogue web.
- **Avantages** :
  - Alternative à l’héritage complexe.
  - Gestion dynamique des fonctionnalités.

### 3.4 Bridge
- **But** : Séparer une abstraction de son implémentation pour qu’elles puissent évoluer indépendamment.
- **Exemple** :
  - Système de rendu graphique avec des APIs différentes (OpenGL, DirectX).
  - Gestion de différentes plates-formes (Windows, Linux) avec des abstractions communes.
- **Avantages** :
  - Améliore la flexibilité.
  - Réduit la complexité des hiérarchies.

## 4. Patterns Comportementaux

### 4.1 Chain of Responsibility
- **But** :
  - Permet de transmettre une requête à travers une chaîne d’objets jusqu’à ce qu’elle soit traitée.
- **Exemple** :
  - Gestion des requêtes HTTP dans des middlewares.
  - Validation d’un formulaire avec différents étapes.
- **Avantages** :
  - Simplifie l’ajout de nouvelles responsabilités.
  - Réduit les dépendances directes entre les objets.

### 4.2 Command
- **But** :
  - Encapsule une requête sous forme d’objet, permettant ainsi de découpler les expéditeurs et les récepteurs.
- **Exemple** :
  - Implémentation d’un système d’annulation/répétition (undo/redo).
  - Gestion de menus dans une interface utilisateur.
- **Avantages** :
  - Favorise l’extensibilité.
  - Simplifie l’enregistrement et l’exécution de commandes.

## Notes supplémentaires (infos autres de Mounir)

1. **Namespace en C#** :
   - Une sorte de bibliothèque pour organiser le code.
2. **Commandes utiles en .NET** :
   - `dotnet new console -o ConsoleProject`
   - `dotnet build`
   - `dotnet run`
   - `dotnet new list` : Afficher les templates disponibles.
3. **Clonage en C#** :
   - `resultat = (Document)this.MemberwiseClone();` : Effectue un clonage superficiel (shallow copy).
4. **Outils recommandés** :
   - [Excalidraw](https://excalidraw.com/) pour les diagrammes UML.
   - [Roadmap.sh](https://roadmap.sh/) pour des roadmaps de professionnalisation.
5. **Site utile pour les patterns** :
   - [Refactoring.guru](https://refactoring.guru/design-patterns).
6. **Site utile pour les diagrammes** :
   - [Mermaid](https://mermaid.live/edit).