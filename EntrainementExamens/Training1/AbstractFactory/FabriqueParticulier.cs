public class FabriqueParticulier : IFabriqueDocumentBancaire
{
    public IReleveIdentiteBancaire CreerReleveIdentiteBancaire()
    {
        return new ReleveIdentiteBancaireSimplifie();
    }

    public IAttestationCompte CreerAttestationCompte()
    {
        return new AttestationCompteStandard();
    }
}
