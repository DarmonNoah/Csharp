1. Voir diagramme UML abstractFactory

2. Voir fichier .cs du dossier

3. Comment votre solution permettrait-elle d'ajouter facilement un nouveau type de document (par exemple une attestation fiscale) tout en respectant le principe Open/Closed ?

Le principe Open/Closed (ouvert aux extensions, fermé aux modifications) est respecté car :

Les interfaces abstraites (IReleveIdentiteBancaire et IAttestationCompte) permettent de définir les comportements généraux des documents.
Les fabriques concrètes (FabriqueParticulier et FabriqueProfessionnel) encapsulent la logique spécifique de création, ce qui évite de modifier le code existant.
Ajout d’un nouveau type de document
Pour ajouter un nouveau type de document, comme une attestation fiscale, il suffit de :

Créer une nouvelle interface ou implémentation concrète (par exemple, AttestationFiscale).
Ajouter une méthode de création correspondante dans la fabrique abstraite (IFabriqueDocumentBancaire) et ses implémentations concrètes.
Aucune modification majeure du code existant n’est nécessaire, seules des extensions sont ajoutées.