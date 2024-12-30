Les participants au pattern sont les suivants :

- ConstructeurAbstrait (ConstructeurLiasseVéhicule) est la classe introduisant les signatures des méthodes construisant les différentes parties du produit ainsi que la signature de la méthode permettant d’obtenir le produit, une fois celui-ci construit.

- ConstructeurConcret (ConstructeurLiasseVéhiculeHtml et ConstructeurLiasseVéhiculePdf) est la classe concrète implantant les méthodes du constructeur abstrait.

- Produit (Liasse) est la classe définissant le produit. Elle peut être abstraite et posséder plusieurs sous-classes concrètes (LiasseHtml et LiassePdf) en cas d’implantations différentes.

- Directeur est la classe chargée de construire le produit au travers de l’interface du constructeur abstrait.
