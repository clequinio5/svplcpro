# SVPLC PRO
Logiciel de permaculture prenant en compte les associations et les rotations entre les plantes

Svplc Pro est un client lourd développé en VB.NET sur VS2010 avec le Framework .NET 4.5. 
Les bases de données sont des fichiers .txt que le programme charge au démarrage.

L'idée initiale était de développer un logiciel au design sobre, qui puisse permettre au jardinier amateur d'organiser ses cultures aussi bien dans l'espace (associations et rotations optimisées entre les cultures, prise en compte de l'ensoleillement et de la pousse des plantes...) que dans le temps (quand et comment accomplir une action de culture, avec quels outils et sous quelles conditions météorologiques...). 

Ce travail a donné lieu à des échanges très intéressants avec des associations comme Vîle Fertile désireuse d'obtenir un outil propre et facile d'utilisation pour centraliser ses connaissances, avec des chercheurs également intéressés par la R&D autour des 'affinités' entre les plantes, qui reste, encore aujourd'hui, un domaine complexe avec de nombreux paramètres à prendre en compte, un manque significatif d'expérience et de données, et une communication peu marquée.

La principale difficulté rencontré sur le développement de ce logiciel est le fait d'avoir a représenté sur 2 dimensions (son écran) un minimum de 3 dimensions (spatiale: 2 voire 3, temporelle: 1). Pour répondre à ce besoin j'ai choisi de réaliser 3 sous-projets qui correspondent chacun à un chemin de pensée différents. Le plus aboutit est la représentation à dominante spatiale.

Dans cette représentation, l'utilisateur dessine phase par phase son jardin. Chaque phase correspond à un onglet. La Phase 2 vient après la Phase 1. L'objet Parcelle permet d'ajouter la composante temporelle ainsi que les actions à effectuer sur la parcelle dessinée. Une Parcelle est un ensemble de cellules accolées sur laquelle la Plante cultivée est la même. Le nombre de phase n'est volontairement pas limité, le nombre de parcelle non plus, le zoom est permis sur la grille par le Ctrl + Molette.

Des améliorations envisageables:
  - Mettre en place un outil récapitulatif final, une fois l'ensemble des phases dessinées pour avoir une vision d'ensemble du projet
  - Remplacer les fichiers textes par une vraie base de données.
  - Démarcher les chercheurs en permaculture pour venir l'enrichir et la justifier.
  - Remplacer les images standards par des images vectorielles pour permettre un agrandissement de qualité des grilles.
  - Prendre en compte l'ensoleillement des plantes.



