# NTiConfigurationHelper

## Introduction

Ce projet offre l'implémentation de l'interface de gestion de la licence NTi en ligne de commandes.

Utilisez ce projet pour ajouter, supprimer, mettre à jour et vérifier la validité votre clé de licence NTi.

Vous pouvez également récupérer les informations nécessaires à fournir lors de la demande d'une nouvelle clé de licence NTi.

## Utilisation en local (nécessite la runtime .NET 8)

Clonez ce dépôt dans le répertoir de votre choix:

```
git clone https://www.github.com/Aumerial/NTiConfigurationHelper
```

Executez le projet:

```
cd NtiConfigurationHelper
dotnet run
```

## Utilisation via Docker (nécessite docker)

Cette image est compatible avec les plateformes AMD64.

Depuis un invite de commande, exécute la commande suivante:

```
docker run -it --rm docker.io/aumerial/nticonfigurationhelper:latest
```