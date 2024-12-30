// Builders/ConstructeurLiasseVehiculeHtml.cs
public class ConstructeurLiasseVehiculeHtml : ConstructeurLiasseVehicule
{
    public ConstructeurLiasseVehiculeHtml()
    {
        liasse = new Liasse();
    }

    public override void ConstruitBonDeCommande(string nomClient)
    {
        liasse.AjouterDocument($"<HTML>Bon de commande pour {nomClient}</HTML>");
    }

    public override void ConstruitDemandeImmatriculation(string nomClient)
    {
        liasse.AjouterDocument($"<HTML>Demande d'immatriculation pour {nomClient}</HTML>");
    }
}
