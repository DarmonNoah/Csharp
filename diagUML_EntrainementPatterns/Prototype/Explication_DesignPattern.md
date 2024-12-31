Le design pattern Prototype permet de créer des copies d'objets existants sans rendre le
code dépendant de leurs classes concrètes. Au lieu de créer un objet a partir de zero, on
clone un objet existant (le prototype) et on le modifie si besoin.

C'est comme faire une photocopie d'un document : on copie l'original et on peut modifier
la copie.

L'avantage principal est la création d'objets complexes simplifée.

Cas d'usage:

- Objets avec de nombreuses configuration (editeur graphique : formes geometriques)
  En jeux video, creation d'enemis et leur variation en grande quantité
  Creation d'une configuration par defaut dans un jeu/logiciel (permet de restaurer le defaut
  rapidement et de configurer a nouveau)

Pour eviter la creation d'objets systemes couteux : connexions reseaux, ressources partagées.
