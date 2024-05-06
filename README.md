# NTiConfigurationHelper

## Introduction

Ce projet offre l'implémentation de l'interface de gestion de la licence NTi en ligne de commandes.

Utilisez ce projet pour ajouter, supprimer, mettre à jour et vérifier la validité votre clé de licence NTi.

Vous pouvez également récupérer les informations nécessaires à fournir lors de la demande d'une nouvelle clé de licence NTi.

## Utilisation via l'exécutable

Vous pouvez télécharger et utiliser l'executable de configuration directement, sans installation et sans runtime .NET sur les architectures suivantes:
* [Windows-x86 (64 bits)](https://github.com/Aumerial/NtiConfigurationHelper/releases/download/win-x86/NtiConfigurationHelper.exe)


## Clonage du projet (nécessite la runtime .NET 8)

Clonez ce dépôt dans le répertoir de votre choix:

```
git clone https://www.github.com/Aumerial/NTiConfigurationHelper
```

Executez les commandes suivantes pour exécuter le projet:

```
cd NtiConfigurationHelper
dotnet run
```

## Utilisation de l'image Docker (nécessite docker)

Cette image est compatible avec les plateformes AMD64.

Depuis un invite de commande, exécutez la commande suivante:

```
docker run -it --rm docker.io/aumerial/nticonfigurationhelper:latest
```