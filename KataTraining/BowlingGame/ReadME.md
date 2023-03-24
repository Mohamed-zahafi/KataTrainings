
**Niveau :** Moyen

Le jeu se compose de 10 tours. Dans chaque tour, le joueur a deux lancers pour faire tomber 10 quilles. Le score du cadre est le nombre total de quilles abattues, plus les bonus pour les strikes et les spares.
 - On parle de réserve lorsque le joueur fait tomber les 10 quilles en deux lancers. Le bonus pour ce cadre est le nombre de quilles abattues au prochain lancer. 
 - On parle de strike lorsque le joueur fait tomber les 10 quilles lors de son premier lancer. Le cadre est alors complété par un seul lancer. Le bonus pour ce cadre est la valeur des deux lancers suivants. 
 - Dans le dixième carreau, un joueur qui a obtenu un spare ou un strike est autorisé à lancer les boules supplémentaires pour terminer le carreau. Toutefois, il ne peut pas lancer plus de trois boules dans le dixième tour.


Les règles de calcul du bowling sont relativement simples, 
mais peuvent sembler un peu complexes pour les débutants. Voici comment calculer les scores:

Si un joueur renverse toutes les quilles en un seul lancer (un "strike"), 
il reçoit 10 points plus le nombre de quilles renversées lors des deux lancers suivants. Par exemple, si un joueur réalise un strike au premier lancer, puis renverse 7 quilles au deuxième lancer et 2 quilles au troisième lancer, son score pour le premier tour sera de 10 + 7 + 2 = 19 points.

Si un joueur renverse toutes les quilles en deux lancers (un "spare"), 
il reçoit 10 points plus le nombre de quilles renversées lors du lancer suivant. Par exemple, si un joueur réalise un spare au premier tour (en renversant 7 quilles au premier lancer et les 3 quilles restantes au deuxième lancer), puis renverse 5 quilles au deuxième lancer, son score pour le premier tour sera de 10 + 5 = 15 points.

Si un joueur ne réalise ni un strike ni un spare, 
son score pour le tour est simplement le nombre de quilles qu'il a renversées en deux lancers.

Le score total d'un joueur est la somme de ses scores pour chaque tour, 
plus les points bonus qu'il a éventuellement gagnés en réalisant des spares ou des strikes.

Si un joueur réalise un strike ou un spare dans le dixième tour, 
il a droit à des lancers supplémentaires pour terminer le tour et marquer des points bonus si nécessaire.

Le score maximum possible dans une partie de bowling est de 300 points, 
en réalisant 12 strikes d'affilée (10 strikes réguliers et deux lancers bonus pour le dixième tour).


    # Bowling Game Classic

Attention, pour ce kata, on ne s'intéresse qu'aux parties terminées et correctes.  
La version plus difficile est [ici](../BowlingGameHardcore/README.md)

## Exigences

Écrivez une classe Game qui possède deux méthodes :
1. **void roll(int)** est appelé chaque fois que le joueur lance une boule. L'argument est le nombre de quilles abattues.
2. **int score()** renvoie le score total pour cette partie.

## Aide

### Step 1 - Règles classiques

Entrée : vide  
Score attendu : 0

Entrée : On roll 20 fois 0   
Score attendu : 0

Entrée : On roll 20 fois 1  
Score attendu : 20

### Step 2 - Le Spare

Entrée : On roll 7, 3 puis 4 & 17 fois 0  
Score attendu : 18

### Step 3 - Le Strike

Entrée : On roll 10, 3 puis 4 & 16 fois 0  
Score attendu : 24

### Step 4 - Le cas du génie

Entrée : On roll 12 fois 10  
Score attendu : 300