public class FabriqueProfessionnel : IFabriqueDocumentBancaire
{
    public IReleveIdentiteBancaire CreerReleveIdentiteBancaire()
    {
        return new ReleveIdentiteBancaireDetaille();
    }

    public IAttestationCompte CreerAttestationCompte()
    {
        return new AttestationCompteMentionsLegales();
    }
}
