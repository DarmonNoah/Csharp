// Builders/ConstructeurLiasseVehiculePdf.cs
public class ConstructeurLiasseVehiculePdf : ConstructeurLiasseVehicule
{
    public ConstructeurLiasseVehiculePdf()
    {
        liasse = new Liasse();
    }

    public override void ConstruitBonDeCommande(string nomClient)
    {
        liasse.AjouterDocument($"PDF: Bon de commande pour {nomClient}");
    }

    public override void ConstruitDemandeImmatriculation(string nomClient)
    {
        liasse.AjouterDocument($"PDF: Demande d'immatriculation pour {nomClient}");
    }
}
