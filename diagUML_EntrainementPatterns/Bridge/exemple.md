# Exemple du pattern Bridge

Le pattern Bridge sépare une grosse classe ou un ensemble de classes en deux parties distinctes
qui peuvent évoluer indépendamment :

- L'abstraction (ce que l'utilisateur voit et utilise)
- L'implémentation (comment ça fonctionne en interne)

Exemple concret avec des télécommandes TV :

- Abstraction : La télécommande (avec ses boutons volume, chaîne, etc.)
- Implémentation : Les différentes marques de TV (Samsung, Sony, LG...)

C'est comme si vous aviez :

```java
// L'abstraction
class Telecommande {
    protected TV tv;  // Le "pont" vers l'implémentation

    public void volumeHaut() {
        tv.augmenterVolume();
    }
}

// Les implémentations
interface TV {
    void augmenterVolume();
}

class TVSamsung implements TV {
    void augmenterVolume() {
        // Code spécifique Samsung
    }
}

class TVSony implements TV {
    void augmenterVolume() {
        // Code spécifique Sony
    }
}
```

Avantages :

- Vous pouvez changer la marque de TV sans changer la télécommande
- Vous pouvez modifier la télécommande sans toucher au code des TV
- Vous pouvez ajouter de nouvelles marques de TV facilement

C'est comme avoir un adaptateur universel qui fonctionne avec différentes prises électriques

- l'interface reste la même, mais l'implémentation change selon le pays.
