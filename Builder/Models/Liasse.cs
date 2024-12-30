// Models/Liasse.cs
public class Liasse
{
    private List<string> documents = new List<string>();

    public void AjouterDocument(string document)
    {
        documents.Add(document);
    }

    public void Imprime()
    {
        Console.WriteLine("Impression des documents :");
        foreach (var doc in documents)
        {
            Console.WriteLine(doc);
        }
    }
}
