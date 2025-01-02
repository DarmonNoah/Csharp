using System;

class Program
{
    static void Main(string[] args)
    {
        // Fabrique pour les particuliers
        IFabriqueDocumentBancaire fabriqueParticulier = new FabriqueParticulier();
        var releveParticulier = fabriqueParticulier.CreerReleveIdentiteBancaire();
        var attestationParticulier = fabriqueParticulier.CreerAttestationCompte();

        Console.WriteLine("Documents pour les particuliers :");
        releveParticulier.Afficher();
        attestationParticulier.Afficher();

        // Fabrique pour les professionnels
        IFabriqueDocumentBancaire fabriqueProfessionnel = new FabriqueProfessionnel();
        var releveProfessionnel = fabriqueProfessionnel.CreerReleveIdentiteBancaire();
        var attestationProfessionnel = fabriqueProfessionnel.CreerAttestationCompte();

        Console.WriteLine("\nDocuments pour les professionnels :");
        releveProfessionnel.Afficher();
        attestationProfessionnel.Afficher();
    }
}
