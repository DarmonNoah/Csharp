# Pattern C#

## Introduction

design pattern = schéma d'objet qui résout un problème récurrent

Ensemble de classes et de relations dans le cadre de la POO

Design pattern => basé sur des bonnes pratiques

## Description des patterns

Le langage UML et C#

Pour chaque pattern : - Nom - Description - Exemple sous forme d'UML - Structure générique du pattern - Le cas d'utilisation - Un exemple de code en C# - [lien vers refactoring.guru ](https://refactoring.guru)

# Étude de cas : la vente en ligne de véhicules

Véhicule destiné à la vente en ligne

- Catalogue de véhicules
- Options de véhicules
- Panier / Gestion de Commandes
- Gestion des clients

# Les patterns

Abstract Factory = Construire les objets du domaine (Automobile à essence, électrique, hybride)
Builder, Prototype = Construire les liasses de documents nécéssaires en cas d'acquisition d'un véhicule
Factory Method = Créer des commandes
Singleton = Créer la liasse vierge de documents

But = abstraire les mécanismes

## Singleton

### Singleton Pattern

Le pattern Singleton garantit qu'une classe n'a qu'une seule instance et fournit un point d'accès global à cette instance.

#### Exemple UML

![Singleton UML](https://refactoring.guru/images/patterns/diagrams/singleton/structure.png)

#### Structure Générique

```csharp
public class Singleton
{
    private static Singleton instance;

    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
```

#### Cas d'utilisation

- Lorsque vous avez besoin d'exactement une instance d'une classe.
- Lorsque l'instance unique doit être accessible de n'importe où dans le programme.

#### Exemple de code en C#

```csharp
public class ConfigurationManager
{
    private static ConfigurationManager instance;
    private static readonly object lockObject = new object();

    private ConfigurationManager()
    {
        // Initialisation des paramètres de configuration
    }

    public static ConfigurationManager Instance
    {
        get
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new ConfigurationManager();
                }
                return instance;
            }
        }
    }

    public string GetConfigValue(string key)
    {
        // Retourne la valeur de configuration pour la clé donnée
        return "value";
    }
}
```

#### [Lien vers refactoring.guru](https://refactoring.guru/fr/design-patterns/singleton)

#### Abstract Factory Design Pattern

Le but du pattern est la creation d'objets
regroupes en familles sans devoir
connaitre les classes concretes destinées
a la creation de ces objets.

C# est un langage compilé donc compréhensible par l'humain, le but est de fournir un exec compréhensible par la machine ou plutot ton système d'exploitation, dotnet est crossplateforme, dotnet new list permet de voir la liste des templates disponibles.

un namespace est une sorte de bibliotheque

site utile : https://refactoring.guru/design-patterns

exemple dans builder :

Le pattern Builder est un design utilisé pour construire un objet complexe étape par étape. Voici les participants du pattern, comme décrit dans Participants.md (dossier builder) :

ConstructeurAbstrait : C'est une classe abstraite ou une interface qui définit les méthodes nécessaires pour construire chaque partie du produit (par exemple, un bon de commande ou une demande d'immatriculation).

ConstructeurConcret : Ce sont les classes concrètes qui implémentent les méthodes définies par le constructeur abstrait pour générer les documents spécifiques (HTML ou PDF, par exemple).

Produit : C'est l'objet final créé, ici une Liasse. Ce produit peut avoir plusieurs types (par exemple, une liasse HTML ou PDF).

Directeur : C'est une classe responsable d'orchestrer la construction du produit en utilisant les méthodes définies par le constructeur abstrait.

Pour faire des diag UML il est possible d'utiliser Excalidraw.

resultat = (Document)this.MemberwiseClone();
effectue un clonage superficiel (shallow copy) de l'objet actuel (this) et le cast en un objet du type Document.

Roadmap.sh est un site pour obtenir des roadmap qui permettent de connaitre notre professionnalisation.
