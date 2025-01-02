using System;
using System.Collections.Generic;

namespace RefactoringGuru.DesignPatterns.ChainOfResponsibility.Conceptual
{
    // L'interface Handler déclare une méthode pour construire la chaîne
    // de responsabilités entre les handlers. Elle déclare également une
    // méthode pour traiter une requête.
    public interface IHandler
    {
        // Permet de définir le prochain handler dans la chaîne.
        IHandler SetNext(IHandler handler);

        // Traite une requête ou la transfère au prochain handler.
        object Handle(object request);
    }

    // Le comportement par défaut pour chaîner les handlers peut être
    // implémenté dans une classe de base abstraite.
    abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        // Définit le prochain handler dans la chaîne.
        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;

            // Retourne un handler pour permettre de lier les handlers
            // de manière fluide comme ceci :
            // vehicule.SetNext(modele).SetNext(marque);
            return handler;
        }

        // Traite la requête ou la transfère au prochain handler
        // s'il existe.
        public virtual object Handle(object request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);
            }
            else
            {
                return null; // Renvoie null si aucun handler n'a traité la requête.
            }
        }
    }

    // Handler concret qui traite les "bananes".
    class VehiculeHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Banana")
            {
                return $"vehicule: {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request); // Transfère la requête au prochain handler.
            }
        }
    }

    // Handler concret qui traite les "noix".
    class ModeleHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Nut")
            {
                return $"modele: {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request); // Transfère la requête au prochain handler.
            }
        }
    }

    // Handler concret qui traite les "boulettes de viande".
    class MarqueHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "MeatBall")
            {
                return $"marque: {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request); // Transfère la requête au prochain handler.
            }
        }
    }

    class Client
    {
        // Le code client est conçu pour fonctionner avec un seul handler.
        // Dans la plupart des cas, il n'est pas conscient que le handler
        // fait partie d'une chaîne.
        public static void ClientCode(AbstractHandler handler)
        {
            // Une liste de "nourritures" à traiter.
            foreach (var food in new List<string> { "Nut", "Banana", "Cup of coffee" })
            {
                Console.WriteLine($"Client : Qui veut une {food}?");

                var result = handler.Handle(food);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {food} a été laissée de côté.");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // La deuxième partie du code client construit la chaîne réelle.
            var vehicule = new VehiculeHandler();
            var modele = new ModeleHandler();
            var marque = new MarqueHandler();

            // Construction de la chaîne : vehicule > modele > marque
            vehicule.SetNext(modele).SetNext(marque);

            // Le client doit pouvoir envoyer une requête à n'importe quel handler,
            // pas uniquement au premier dans la chaîne.
            Console.WriteLine("Chaîne : Vehicule > Modele > Marque\n");
            Client.ClientCode(vehicule);
            Console.WriteLine();

            Console.WriteLine("Sous-chaîne : Modele > Marque\n");
            Client.ClientCode(modele);
        }
    }
}