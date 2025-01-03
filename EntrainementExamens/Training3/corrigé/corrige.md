# Corrigé :

1. Le pattern Bridge est utilisé pour :

   - Séparer l'abstraction (types de notifications) de l'implémentation (plateformes d'envoi)
   - Permettre leur évolution indépendante
   - Éviter l'explosion combinatoire des classes

2. Structure de la solution :

   - `IPlateformeEnvoi` : interface pour les implémentations d'envoi
   - Classes concrètes d'envoi : `EnvoiEmail`, `EnvoiSMS`, `EnvoiPush`
   - Classe abstraite `Notification` avec référence à `IPlateformeEnvoi`
   - Classes concrètes de notifications : `NotificationCommande`, etc.

3. Avantages de cette solution :

   - Découplage entre les types de notifications et les méthodes d'envoi
   - Facilité d'ajout de nouveaux types de notifications
   - Facilité d'ajout de nouvelles plateformes
   - Réutilisation du code d'envoi
   - Flexibilité dans les combinaisons notification/plateforme

4. Pour étendre le système :

   - Nouveau type de notification : créer une nouvelle classe héritant de `Notification`
   - Nouvelle plateforme : implémenter `IPlateformeEnvoi`
   - Modification d'une plateforme : modifier uniquement la classe concernée

5. Comparaison avec le code initial :
   - Élimination de la duplication de code
   - Meilleure organisation du code
   - Plus grande flexibilité
   - Maintenance facilitée

Cette implémentation résout les problèmes du code initial en :

- Séparant clairement les responsabilités
- Permettant l'évolution indépendante des deux aspects
- Facilitant les modifications et extensions
- Améliorant la réutilisation du code
