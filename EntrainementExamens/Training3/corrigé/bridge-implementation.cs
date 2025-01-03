// Interface pour l'implémentation des plateformes d'envoi
public interface IPlateformeEnvoi
{
    void Envoyer(string message);
}

// Implémentations concrètes des plateformes d'envoi
public class EnvoiEmail : IPlateformeEnvoi
{
    public void Envoyer(string message)
    {
        Console.WriteLine($"Email: {message}");
    }
}

public class EnvoiSMS : IPlateformeEnvoi
{
    public void Envoyer(string message)
    {
        Console.WriteLine($"SMS: {message}");
    }
}

public class EnvoiPush : IPlateformeEnvoi
{
    public void Envoyer(string message)
    {
        Console.WriteLine($"Push: {message}");
    }
}

// Classe abstraite de base pour les notifications
public abstract class Notification
{
    protected IPlateformeEnvoi plateformeEnvoi;

    protected Notification(IPlateformeEnvoi plateforme)
    {
        plateformeEnvoi = plateforme;
    }

    public void Notifier(string message)
    {
        EnvoyerNotification(message);
    }

    protected abstract void EnvoyerNotification(string message);
}

// Types concrets de notifications
public class NotificationCommande : Notification
{
    public NotificationCommande(IPlateformeEnvoi plateforme) : base(plateforme) { }

    protected override void EnvoyerNotification(string message)
    {
        plateformeEnvoi.Envoyer($"Commande: {message}");
    }
}

public class NotificationLivraison : Notification
{
    public NotificationLivraison(IPlateformeEnvoi plateforme) : base(plateforme) { }

    protected override void EnvoyerNotification(string message)
    {
        plateformeEnvoi.Envoyer($"Livraison: {message}");
    }
}

public class NotificationSupport : Notification
{
    public NotificationSupport(IPlateformeEnvoi plateforme) : base(plateforme) { }

    protected override void EnvoyerNotification(string message)
    {
        plateformeEnvoi.Envoyer($"Support: {message}");
    }
}

// Programme de démonstration
class Program
{
    static void Main(string[] args)
    {
        // Création des plateformes d'envoi
        IPlateformeEnvoi email = new EnvoiEmail();
        IPlateformeEnvoi sms = new EnvoiSMS();
        IPlateformeEnvoi push = new EnvoiPush();

        // Création et utilisation des notifications
        Notification commande = new NotificationCommande(email);
        commande.Notifier("Votre commande est confirmée");

        Notification livraison = new NotificationLivraison(sms);
        livraison.Notifier("Votre colis est en route");

        Notification support = new NotificationSupport(push);
        support.Notifier("Un agent va vous contacter");

        // Démonstration de la flexibilité : même notification, différentes plateformes
        Notification commandeSMS = new NotificationCommande(sms);
        commandeSMS.Notifier("Votre commande est confirmée");
    }
}
