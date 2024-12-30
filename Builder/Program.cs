// See https://aka.ms/new-console-template for more information

// Declaration de constructeur / builder
// Determiner son type a l'aide du schema

// Proposer a l'utilisateur de choisir un type de
// documents ( liasse pdf ou liasse html)

// Creation d'une instance de la classe Vendeur qui prend en parametre un objet de type ConstructeurLiasseVehicule ...

// Vendeur.construit("nom client particulier"); retourne un une instance de type LiasseVehicule (html ou pdf ou autre)
// qu'on peut stocker dans une variable liasse

// liasse.imprime(); // imprime le contenu de la liasse (html ou pdf ou autre)

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenue dans le système de création de liasses !");
        Console.WriteLine("==================================================");

        // Demande du nom du client
        Console.Write("Veuillez entrer le nom du client : ");
        string nomClient = Console.ReadLine();

        // Explication des options pour HTML ou PDF
        Console.WriteLine("\nChoisissez le format des documents :");
        Console.WriteLine("Tapez 'HTML' pour des documents au format HTML.");
        Console.WriteLine("Tapez 'PDF' pour des documents au format PDF.");
        Console.Write("\nVotre choix : ");
        string choix = Console.ReadLine();

        // Instanciation du constructeur correspondant
        ConstructeurLiasseVehicule constructeur;

        if (choix.ToUpper() == "HTML")
        {
            constructeur = new ConstructeurLiasseVehiculeHtml();
            Console.WriteLine("\nVous avez choisi le format HTML.");
        }
        else if (choix.ToUpper() == "PDF")
        {
            constructeur = new ConstructeurLiasseVehiculePdf();
            Console.WriteLine("\nVous avez choisi le format PDF.");
        }
        else
        {
            // Gestion des erreurs si l'utilisateur ne fait pas un choix valide
            Console.WriteLine("\nChoix invalide. Par défaut, le format HTML sera utilisé.");
            constructeur = new ConstructeurLiasseVehiculeHtml();
        }

        // Création du directeur (Vendeur)
        Vendeur vendeur = new Vendeur(constructeur);

        // Construction de la liasse pour le client spécifique
        Liasse liasse = vendeur.Construit(nomClient);

        // Impression de la liasse
        Console.WriteLine("\nVoici le contenu de la liasse générée :");
        liasse.Imprime();

        Console.WriteLine("\nMerci d'avoir utilisé notre système !");
    }
}
