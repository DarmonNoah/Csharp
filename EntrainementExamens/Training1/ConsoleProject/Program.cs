// Interfaces des produits
public interface IBancaireRIB
{
    string GenererRIB();
}

public interface IBancaireAttestation
{
    string GenererAttestation();
}

// Produits concrets pour les particuliers
public class RIBParticulier : IBancaireRIB
{
    public string GenererRIB()
    {
        return "RIB Particulier: Format simplifié";
    }
}

public class AttestationParticulier : IBancaireAttestation
{
    public string GenererAttestation()
    {
        return "Attestation Particulier: Format standard";
    }
}

// Produits concrets pour les professionnels
public class RIBProfessionnel : IBancaireRIB
{
    public string GenererRIB()
    {
        return "RIB Professionnel: Format détaillé avec SIRET";
    }
}

public class AttestationProfessionnel : IBancaireAttestation
{
    public string GenererAttestation()
    {
        return "Attestation Professionnel: Format avec mentions légales";
    }
}

// Fabrique abstraite
public abstract class DocumentBancaireFactory
{
    public abstract IBancaireRIB CreateRIB();
    public abstract IBancaireAttestation CreateAttestation();
}

// Fabriques concrètes
public class ParticulierFactory : DocumentBancaireFactory
{
    public override IBancaireRIB CreateRIB()
    {
        return new RIBParticulier();
    }

    public override IBancaireAttestation CreateAttestation()
    {
        return new AttestationParticulier();
    }
}

public class ProfessionnelFactory : DocumentBancaireFactory
{
    public override IBancaireRIB CreateRIB()
    {
        return new RIBProfessionnel();
    }

    public override IBancaireAttestation CreateAttestation()
    {
        return new AttestationProfessionnel();
    }
}

// Client
class Program
{
    static void Main(string[] args)
    {
        // Test avec un client particulier
        DocumentBancaireFactory factoryParticulier = new ParticulierFactory();
        IBancaireRIB ribParticulier = factoryParticulier.CreateRIB();
        IBancaireAttestation attestationParticulier = factoryParticulier.CreateAttestation();

        Console.WriteLine(ribParticulier.GenererRIB());
        Console.WriteLine(attestationParticulier.GenererAttestation());

        // Test avec un client professionnel
        DocumentBancaireFactory factoryProfessionnel = new ProfessionnelFactory();
        IBancaireRIB ribProfessionnel = factoryProfessionnel.CreateRIB();
        IBancaireAttestation attestationProfessionnel = factoryProfessionnel.CreateAttestation();

        Console.WriteLine(ribProfessionnel.GenererRIB());
        Console.WriteLine(attestationProfessionnel.GenererAttestation());
    }
}
