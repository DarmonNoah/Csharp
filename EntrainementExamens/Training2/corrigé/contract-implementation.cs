using System;
using System.Collections.Generic;

// Classe abstraite de base pour les contrats
public abstract class Contrat
{
    protected string clausesStandard;
    protected Dictionary<string, string> informationsClient;
    protected List<string> annexes;

    protected Contrat(string clauses)
    {
        this.clausesStandard = clauses;
        this.informationsClient = new Dictionary<string, string>();
        this.annexes = new List<string>();
    }

    // Méthode de clonage à implémenter par les sous-classes
    public abstract Contrat Clone();

    // Méthode pour personnaliser le contrat
    public virtual void Personnaliser(Dictionary<string, string> infos)
    {
        foreach (var info in infos)
        {
            informationsClient[info.Key] = info.Value;
        }
    }

    public override string ToString()
    {
        return $"Contrat avec clauses: {clausesStandard}\nInformations client: {string.Join(", ", informationsClient)}";
    }
}

// Implémentations concrètes des contrats
public class ContratHabitation : Contrat
{
    public ContratHabitation() : base("Clauses standard habitation") { }

    public override Contrat Clone()
    {
        ContratHabitation clone = new ContratHabitation();
        clone.informationsClient = new Dictionary<string, string>(this.informationsClient);
        clone.annexes = new List<string>(this.annexes);
        return clone;
    }
}

public class ContratAutomobile : Contrat
{
    public ContratAutomobile() : base("Clauses standard automobile") { }

    public override Contrat Clone()
    {
        ContratAutomobile clone = new ContratAutomobile();
        clone.informationsClient = new Dictionary<string, string>(this.informationsClient);
        clone.annexes = new List<string>(this.annexes);
        return clone;
    }
}

public class ContratVie : Contrat
{
    public ContratVie() : base("Clauses standard assurance vie") { }

    public override Contrat Clone()
    {
        ContratVie clone = new ContratVie();
        clone.informationsClient = new Dictionary<string, string>(this.informationsClient);
        clone.annexes = new List<string>(this.annexes);
        return clone;
    }
}

// Gestionnaire des prototypes de contrats
public class GestionnaireContrats
{
    private Dictionary<string, Contrat> prototypes;

    public GestionnaireContrats()
    {
        prototypes = new Dictionary<string, Contrat>();
        
        // Initialisation des prototypes
        prototypes.Add("Habitation", new ContratHabitation());
        prototypes.Add("Automobile", new ContratAutomobile());
        prototypes.Add("Vie", new ContratVie());
    }

    public Contrat CreerContrat(string type)
    {
        if (!prototypes.ContainsKey(type))
            throw new ArgumentException($"Type de contrat inconnu : {type}");

        return prototypes[type].Clone();
    }
}

// Programme de démonstration
class Program
{
    static void Main(string[] args)
    {
        GestionnaireContrats gestionnaire = new GestionnaireContrats();

        // Création et personnalisation d'un contrat habitation
        Contrat contratHabitation = gestionnaire.CreerContrat("Habitation");
        contratHabitation.Personnaliser(new Dictionary<string, string>
        {
            {"Nom", "Dupont"},
            {"Adresse", "123 rue de la Paix"},
            {"Franchise", "500€"}
        });

        // Création d'une variante du même contrat
        Contrat contratHabitationVariante = contratHabitation.Clone();
        contratHabitationVariante.Personnaliser(new Dictionary<string, string>
        {
            {"Franchise", "1000€"}
        });

        Console.WriteLine("Contrat original:");
        Console.WriteLine(contratHabitation);
        Console.WriteLine("\nVariante du contrat:");
        Console.WriteLine(contratHabitationVariante);
    }
}
