#Question :

Comment peut-on decorer un cafe avec du lait et du sucre ?

#Réponse :

###En me basant sur la doc de https://refactoring.guru/design-patterns/decorator expliquant la structure du pattern decorator :

Le café représente le composant qui déclare une interface commune à tous les types de cafés, qu’ils soient simples ou enrichis avec des ajouts comme le lait ou le sucre.

Le Café Simple est une classe concrète qui définit le comportement de base d'un café, à savoir son coût et sa description. Il représente un café sans ajout.

La classe Base Décorateur est représentée ici par le décorateur abstrait CafeDecorator. Elle contient un champ qui référence un objet café encapsulé (par exemple, un Café Simple ou un autre décorateur). Cette classe délègue toutes les opérations à l'objet encapsulé, ce qui permet une extension du comportement tout en respectant l'interface commune.

Les ajouts concrets, comme le lait (Lait) et le sucre (Sucre), sont des décorateurs concrets. Ils définissent des comportements supplémentaires qui s'ajoutent dynamiquement au café. Par exemple, le décorateur Lait ajoute un coût supplémentaire et modifie la description pour indiquer la présence de lait, tandis que Sucre fait de même pour le sucre.

Le client peut enrichir un café en le "décorant" dynamiquement avec plusieurs couches de décorateurs. Par exemple, un Café Simple peut être enveloppé successivement par un décorateur Lait puis par un décorateur Sucre, pour obtenir un café enrichi avec du lait et du sucre, tout en conservant un fonctionnement uniforme grâce à l'interface commune.

Correction :

Concrètement on voit dans le code fournis par le professeur que CafeSimple & CafeDecorator héritent de ICafe,
par la suite on remarque que les classes Lait et Sucre héritent égalements de CafeDecorator.
Tout cela permet de structurer le code de manière à pouvoir l'améliorer si le client demande d'ajouter de nouvelles décorations (par exemple chantillie, etc..) SANS AVOIR A MODIFIER L'ANCIEN CODE (dans notre cas la classe café).