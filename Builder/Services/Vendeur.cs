// Services/Vendeur.cs
public class Vendeur
{
    private ConstructeurLiasseVehicule constructeur;

    public Vendeur(ConstructeurLiasseVehicule constructeur)
    {
        this.constructeur = constructeur;
    }

    public Liasse Construit(string nomClient)
    {
        constructeur.ConstruitBonDeCommande(nomClient);
        constructeur.ConstruitDemandeImmatriculation(nomClient);
        return constructeur.ObtenirLiasse();
    }
}
