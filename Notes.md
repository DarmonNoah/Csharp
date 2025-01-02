# Design Patterns en C# : Abstract Factory, Builder, Prototype, Singleton

Les **Design Patterns** sont des solutions réutilisables à des problèmes récurrents dans le développement logiciel. Ici, nous allons explorer les patterns "Abstract Factory", "Builder", "Prototype" et "Singleton" en C# avec des explications et des exemples détaillés.

---

## Abstract Factory

### Définition
Le **pattern Abstract Factory** fournit une interface pour créer des familles d'objets liés ou dépendants sans spécifier leurs classes concrètes. Il est particulièrement utile lorsque vous avez plusieurs variantes d'une famille d'objets et que vous souhaitez garantir qu'ils soient utilisés ensemble.

### Cas d'utilisation
- Lorsque vous devez garantir que les objets créés sont compatibles entre eux.
- Lorsque votre application doit prendre en charge plusieurs familles de produits.
- Exemple : création de composants GUI spécifiques à une plateforme (Windows, MacOS, etc.).

### Structure
![Structure](images/abstractFactory.png)

### Exemple en C#
```csharp
// Interfaces des produits
public interface IButton
{
    void Render();
}

public interface ICheckbox
{
    void Render();
}

// Implémentations concrètes des produits
public class WindowsButton : IButton
{
    public void Render() => Console.WriteLine("Rendering Windows Button");
}

public class MacOSButton : IButton
{
    public void Render() => Console.WriteLine("Rendering MacOS Button");
}

public class WindowsCheckbox : ICheckbox
{
    public void Render() => Console.WriteLine("Rendering Windows Checkbox");
}

public class MacOSCheckbox : ICheckbox
{
    public void Render() => Console.WriteLine("Rendering MacOS Checkbox");
}

// Interface de la fabrique abstraite
public interface IGUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}

// Fabriques concrètes
public class WindowsFactory : IGUIFactory
{
    public IButton CreateButton() => new WindowsButton();
    public ICheckbox CreateCheckbox() => new WindowsCheckbox();
}

public class MacOSFactory : IGUIFactory
{
    public IButton CreateButton() => new MacOSButton();
    public ICheckbox CreateCheckbox() => new MacOSCheckbox();
}

// Client
public class Application
{
    private readonly IButton _button;
    private readonly ICheckbox _checkbox;

    public Application(IGUIFactory factory)
    {
        _button = factory.CreateButton();
        _checkbox = factory.CreateCheckbox();
    }

    public void Render()
    {
        _button.Render();
        _checkbox.Render();
    }
}

// Utilisation
var factory = new WindowsFactory();
var app = new Application(factory);
app.Render();
```

---

## Builder

### Définition
Le **pattern Builder** permet de construire des objets complexes étape par étape. Il sépare la construction d’un objet de sa représentation, ce qui permet d'utiliser le même processus de construction pour différentes représentations.

### Cas d'utilisation
- Lorsque vous devez construire un objet complexe composé de plusieurs étapes.
- Lorsque vous voulez isoler le code de construction du code de représentation.
- Exemple : création d'une maison ou d'un document complexe (PDF, HTML, etc.).

### Structure
![Structure](images/builder.png)

### Exemple en C#
```csharp
// Produit complexe
public class House
{
    public string Walls { get; set; }
    public string Roof { get; set; }
    public string Foundation { get; set; }

    public override string ToString()
    {
        return $"House with {Walls} walls, {Roof} roof, and {Foundation} foundation.";
    }
}

// Interface du constructeur
public interface IHouseBuilder
{
    void BuildWalls();
    void BuildRoof();
    void BuildFoundation();
    House GetResult();
}

// Constructeur concret
public class ConcreteHouseBuilder : IHouseBuilder
{
    private House _house = new House();

    public void BuildWalls() => _house.Walls = "Concrete";

    public void BuildRoof() => _house.Roof = "Concrete";

    public void BuildFoundation() => _house.Foundation = "Concrete";

    public House GetResult() => _house;
}

// Directeur
public class Director
{
    private IHouseBuilder _builder;

    public Director(IHouseBuilder builder)
    {
        _builder = builder;
    }

    public void Construct()
    {
        _builder.BuildFoundation();
        _builder.BuildWalls();
        _builder.BuildRoof();
    }
}

// Utilisation
var builder = new ConcreteHouseBuilder();
var director = new Director(builder);
director.Construct();
House house = builder.GetResult();
Console.WriteLine(house);
```

---

## Prototype

### Définition
Le **pattern Prototype** permet de créer de nouveaux objets en copiant des instances existantes sans rendre le code dépendant de leurs classe concrètes, plutôt que de les créer à partir de zéro on clone un objet existant en le modifiant si besoin. Cela est particulièrement utile lorsqu'il est coûteux ou complexe de créer un nouvel objet à partir de rien. 
- Comme une photocopie d'un document, on copie l'original et on modifie la copie si besoin.

### Cas d'utilisation
- Lorsque la création d’un objet est coûteuse ou complexe (nombreuses configurations).
- Lorsque vous avez besoin d’une copie exacte d’un objet existant.
- Exemple : systèmes de gestion de ressources graphiques, éditeurs de graphismes.

### Structure
![Structure](images/prototype1.png)
![Structure](images/prototype2.png)

### Exemple en C#
```csharp
// Classe Prototype de base
public abstract class Shape
{
    public string Color { get; set; }

    protected Shape(string color)
    {
        Color = color;
    }

    public Shape Clone()
    {
        return (Shape)this.MemberwiseClone();
    }
}

// Classe concrète
public class Circle : Shape
{
    public int Radius { get; set; }

    public Circle(string color, int radius) : base(color)
    {
        Radius = radius;
    }
}

// Utilisation
var circle1 = new Circle("Red", 10);
var circle2 = (Circle)circle1.Clone();

Console.WriteLine($"Circle1: {circle1.Color}, Radius: {circle1.Radius}");
Console.WriteLine($"Circle2: {circle2.Color}, Radius: {circle2.Radius}");
```

---

## Singleton

### Définition
Le **pattern Singleton** garantit qu'une classe n'a qu'une seule instance et fournit un point d'accès global à cette instance. Il est souvent utilisé pour gérer des ressources partagées ou un état global.

### Cas d'utilisation
- Lorsque vous avez besoin d'une seule instance d'une classe (exemple : gestion de la configuration ou connexion à une base de données).
- Lorsque vous devez fournir un accès global à une instance.

### Structure
![Structure](images/singleton.png)

### Exemple en C#
```csharp
public class Singleton
{
    private static Singleton _instance;

    // Constructeur privé pour empêcher l’instanciation.
    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }

    public void DoSomething()
    {
        Console.WriteLine("Singleton en action !");
    }
}

// Utilisation
var singleton = Singleton.Instance;
singleton.DoSomething();
```

---

## Patterns de structuration

Les **patterns de structuration** permettent de définir clairement la manière dont les classes et les objets collaborent entre eux pour former des structures plus complexes et maintenables. Ils facilitent l'indépendance entre l'interface d'un objet et son implémentation, tout en permettant une abstraction accrue de la composition des objets.

Ces patterns encapsulent la manière dont les objets sont composés ou interagissent, tout comme les patterns de création encapsulent le processus de création des objets.

### Principaux patterns de structuration

1. **Adapter**
   - Permet de convertir l'interface d'une classe en une autre interface attendue par le client, facilitant ainsi leur collaboration.
   - **Cas d'utilisation** : Intégrer une bibliothèque ou un code externe dans un système existant.

   Exemple :
   ```csharp
   // Interface cible
   public interface ITarget
   {
       string GetRequest();
   }

   // Classe existante
   public class Adaptee
   {
       public string GetSpecificRequest()
       {
           return "Requête spécifique";
       }
   }

   // Adapter
   public class Adapter : ITarget
   {
       private readonly Adaptee _adaptee;

       public Adapter(Adaptee adaptee)
       {
           _adaptee = adaptee;
       }

       public string GetRequest()
       {
           return _adaptee.GetSpecificRequest();
       }
   }

   // Utilisation
   var adaptee = new Adaptee();
   ITarget target = new Adapter(adaptee);
   Console.WriteLine(target.GetRequest());
   ```

2. **Decorator**
   - Permet d'ajouter dynamiquement des responsabilités supplémentaires à un objet sans modifier sa structure.
   - **Cas d'utilisation** : Étendre des fonctionnalités à un objet sans modifier son code source.

   Exemple :
   ```csharp
   // Interface de base
   public interface IComponent
   {
       void Operation();
   }

   // Composant concret
   public class ConcreteComponent : IComponent
   {
       public void Operation()
       {
           Console.WriteLine("Composant de base");
       }
   }

   // Décorateur abstrait
   public abstract class Decorator : IComponent
   {
       protected IComponent _component;

       protected Decorator(IComponent component)
       {
           _component = component;
       }

       public virtual void Operation()
       {
           _component.Operation();
       }
   }

   // Décorateur concret
   public class ConcreteDecorator : Decorator
   {
       public ConcreteDecorator(IComponent component) : base(component) { }

       public override void Operation()
       {
           base.Operation();
           Console.WriteLine("Comportement ajouté par le décorateur");
       }
   }

   // Utilisation
   var component = new ConcreteComponent();
   var decorated = new ConcreteDecorator(component);
   decorated.Operation();
   ```

3. **Composite**
   - Permet de traiter les objets individuels et les compositions d'objets de manière uniforme.
   - **Cas d'utilisation** : Représenter des hiérarchies d'objets.

4. **Proxy**
   - Fournit un substitut ou un intermédiaire pour contrôler l'accès à un objet.
   - **Cas d'utilisation** : Contrôler l'accès à des ressources coûteuses.

Ces patterns de structuration sont essentiels pour maintenir un code clair, modulaire et flexible.

////////////////////////////////////////////////////////////////////////////////////////

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

Pour faire des diag UML il est possible d'utiliser Excalidraw : [text](https://excalidraw.com/).

resultat = (Document)this.MemberwiseClone();
effectue un clonage superficiel (shallow copy) de l'objet actuel (this) et le cast en un objet du type Document.

Roadmap.sh est un site pour obtenir des roadmap qui permettent de connaitre notre professionnalisation.

Le but du pattern est d'ajouter
dynamiquement des fonctionhalites
supplementaires à un objet.
Aucune modification de l'interface de
l'objet
Transparent vis-a-vis des clients
- Une alternative à la création d'une sous-
classe pour enrichir un objet.