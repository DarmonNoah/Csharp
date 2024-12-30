// Builders/ConstructeurLiasseVehicule.cs
public abstract class ConstructeurLiasseVehicule
{
    protected Liasse liasse; // composition : mecanisme qui permet a une classe de contenir une ou plusieurs 
    //instances d'autres classes comme attributs. Cela permet de modéliser une relation "a un" (has-a).
    //Elle se distingue de l'héritage, qui exprime une relation "est un" (is-a).

    public abstract void ConstruitBonDeCommande(string nomClient);
    public abstract void ConstruitDemandeImmatriculation(string nomClient);

    public Liasse ObtenirLiasse()
    {
        return liasse;
    }
}