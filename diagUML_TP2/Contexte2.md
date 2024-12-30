Lors de l’achat d’un véhicule, un client doit recevoir une liasse définie par un nombre précis de documents tels que le certificat de cession, la demande d’immatriculation ou encore le bon de commande. D’autres types de documents peuvent être ajoutés ou retirés à cette liasse en fonction des besoins de gestion ou des changements de réglementation. Nous introduisons une classe Liasse dont les instances sont des liasses composées des différents documents nécessaires. Pour chaque type de document, nous introduisons une classe correspondante.

Puis nous créons un modèle de liasse qui est une instance particulière de la classe Liasse et qui contient les différents documents nécessaires, documents qui restent vierges. Nous appelons cette liasse la liasse vierge. Ainsi, nous définissons au niveau des instances le contenu précis de la liasse que doit recevoir un client et non au niveau des classes. L’ajout ou la suppression d’un document dans la liasse vierge n’impose pas de modification dans sa classe.

Une fois cette liasse vierge introduite, nous procédons par clonage pour créer les nouvelles liasses. Chaque nouvelle liasse est créée en dupliquant tous les documents de la liasse vierge.

Cette technique basée sur des objets disposant de la capacité de clonage utilise le pattern Prototype, les documents constituant les différents prototypes.
