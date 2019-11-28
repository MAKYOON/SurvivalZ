#LI KEVIN  
#Cours : Beginner Scripting  
  
**28/11**  
  
**Certification Unity** : ayant déjà réalisé ce cours, j'ai re-git tel quel comme je l'avais fais à l'époque, mais j'en ai profité pour  
regarder à nouveau ce qu'il était demandé de faire, et en reprenant les choses à voir.
  
**30/07**  
  
Module 4 : Recorded Video Session: Text Adventure Game Part 2  
  
=> Réalisation de la Partie 2 de la série de vidéos sur le Text Adventure Game. J'ai publié le projet Unity fini : les scripts sont identiques à ceux dans les vidéos, j'ai simplement fait un mini-jeu en français  
Actions possibles : aller (nord, est, sud, ouest) / examiner (épée, chaines) / prendre (épée) / utiliser (épée)  
Le principal dans cette série de vidéos était vraiment l'utilisations des listes, du dictionnaire, des classes abstraites et les héritages, des notions plus approffondies en C#  
  
###########################################################################################  
  
**26/07**  
  
Module 3 : Recorded Video Session: Text Adventure Game Part 1  
  
=> Réalisation de la Partie 1 de la série de vidéos sur le Text Adventure Game. Cela nous permet d'apprendre des notions supplémentaires : le type "Scriptable Object" qui ne s'attache pas à un GameObject comme le MonoBehaviour, et permet de contenir du code et de l'exécuter quando on le souhaite  
On a pu également voir l'utilisations des listes, du dictionnaire, des classes abstraites et les héritages
Pour l'instant je n'ai pas commit le projet Unity, je le publierais une fois la partie 2 terminée.
  
###########################################################################################  

**24/07**

Module 2 : Beginner Scripting

**Partie 1 : Scripts as Behaviour Components** => Ecriture d'un script qui active la gravité du cube lorsqu'on appuie sur "1"  
**Partie 2 : Variables and Functions** => Création d'une variable "myMass" initialisée à 100, et création de la fonction "changeMass" qui, lorsqu'on appuie sur "2", modifie la masse du cube à "myMass" donc 100  
**Partie 3 : Conventions and Syntax** => Rien de nouveau sur cette vidéo, du coup je n'ai rien rajouté  
**Partie 4 : IF Statements** => Rajout d'un "if" dans le script, qui indique que si la masse du cube est égale à 100, on désactive le "Collider" du cube  
**Partie 5 : Loops** => Test des boucles "While", "DoWhile" et "For". Rien de nouveau en soi, pour les tester, voir le GameObject "TestingLoops" et les activer 1 par 1, le résultat est dans la console  
**Partie 6 : Scope and Access Modifiers** => Vidéo expliquant la portée des variables, et la notion de "public" et "private". Ici, j'ai juste rajouté un script avec une variable public, qui s'affiche dans la console (et que l'on peut modifier à travers l'inspecteur du coup) sur la Sphère  
**Partie 7 : Awake and Start** => Vidéo qui explique la différence entre la fonction Awake() et Start(), Awake est appelée dès le lancement du jeu, peu importe si le GameObject est initialisé ou non, alors que Start n'est appelé que lorsque le GameObject est initialisé. Je n'ai rien rajouté dans le projet  
**Partie 8 : Update and FixedUpdate** => Vidéo qui explique la différence entre la fonction Update() et FixedUpdate() : Update() est appelé à chaque frame, mais ça peut être inconsistant car si les frames sont décalées dans le temps, alors les actions le seront également. FixedUpdate est appelé à un temps fixe et est indépendant. FixedUpdate est en général utilisé pour bouger un GameObject qui possède un Rigidbody, en y appliquant des forces. Update peut servir à faire de simple timers, récupérer les inputs, bouger des objets non-physiques..  
**Partie 9 : Vector Maths** => Vidéo rappel sur les vecteurs. J'ai créer un script sur un GameObject appelé "VectorScripts" dans lequel j'ai créer 2 vecteurs A et B, et où j'ai calculé la magnitude d'un vecteur, la somme,soustraction, multiplication par un scalaire, produit scalaire et produit vectoriel entre les deux vecteurs. Note : pour la multiplication par un scalaire, j'ai créer une variable publique "My Scalaire" que l'on peut modifier avant de lancer la scène.  
**Partie 10 : Enabling and Disabling Components** => Création d'un script sur la Sphère, j'y ai rajouté une "Light". En appuyant sur la touche "3" on disable la "Light" (peut se voir dans la scène : la face en bas du cube qui était blanche devient sombre)  
**Partie 11 : Activating GameObjects** => Sur la même Sphère et dans le même script, j'ai rajouté le fait que si on appuie sur la touche "4", cela désactive la Sphère.  
**Partie 12 : Translate and Rotate** => Vidéo qui explique les fonctions transform.Translate et transform.Rotate, ici j'ai juste rajouté un arbre et j'ai copié/collé le script donné (permet de changer l'angle avec flèche gauche/droite, et d'avancer reculer avec flèche haut/bas)  
**Partie 13 : Look At** => Création d'un script sur la caméra, qui utilise la fonction transform.LookAt et qui suit l'objet "Tree"  
**Partie 14 : Linear Interpolation** => Cours qui montre la fonction Lerp (utilisable avec les vecteurs, ou couleurs..) qui permet d'interpoler entre deux valeurs, selon le coefficient choisi.  
**Partie 15 : Destroy** => rajout d'un script sur "Tree", quand on appuie sur la touche "5" on détruit l'objet "Plane" avec un délai de 2 secondes  
**Partie 16 : GetButton and GetKey** => Vidéo qui explique la différence entre les deux : GetButton attend un string avec le nom exact du Bouton dans l'input manager, alors que GetKey ne répond qu'au code spécifique de la touche. Il est recommandé d'utiliser GetButton car on peut modifier les noms des boutons dans l'input manager.  
**Partie 17 : GetAxis** => Vidéo qui explique le fonctionnement de GetAxis : cela retourne une valeur comprise entre -1 et 1. Lorsqu'on appuie sur une touche, on considérera du coup l'axe qui se déplacera de 0 à 1, puis de 1 à 0. De ce fait, la touche est toujours considérée comme "up" même après l'avoir relachée. On peut gérer la vitesse à laquelle l'axe se déplace, et revient. Pour tester, j'ai juste modifié le script "TreeController", et en appuyant sur la flèche de droite, on peut voir que le mouvement est différent si on appuie plus ou moins sur la touche, que lorsque l'on se déplace à l'aide de la touche du bas (qui marche avec Input.GetKey)  
**Partie 18 : OnMouseDown** => Rajout dans le script "CubeScript" sur le "Cube" qui écrit dans la console "Test" lorsque l'on clique dessus  
**Partie 19 : GetComponent** => Vidéo qui montre comment utiliser GetComponent, et qui précise qu'il faut l'utiliser le moins possible car c'est gourmand. On peut accéder aux composants d'un objet, ou même au script d'un autre objet, et du coup à ses variables publiques également. Je n'ai rien rajouté ici  
**Partie 20 : DeltaTime** => Vidéo qui explique l'intérêt de Time.deltaTime => sert surtout à fluidifier les mouvements. Entre autre, chaque frame n'est pas générée exactement de la même manière et dans le même temps, il peut y avoir des écarts, et du coup provoquer une sacade dans le mouvement. Time.deltaTime permet d'ajuster ce problème en gardant un temps constant entre chaque itération, et avoir également une valeur en m/s au lieu de m/frame pour les vitesses. Aucun rajout ici.  
**Partie 21 : DataTypes** => Vidéo qui explique la différence entre les variables de type "value" qui correspondent aux entiers, réels, caractère, chaine de caractères, boolean, et structures, et les variables qui accèdent à une référence grâce à leur adresse. Aucun rajout ici  
**Partie 22 : Classes** => Vidéo sur les classes, qui s'apparentent à des types structurés, mais ce sont des modèles : on peut créer des objets grâce aux constructeurs créer dans la class. Aucun rajout ici  
**Partie 23 : Instantiate** => J'ai importé un asset de pistolet et de balle, et créer un script qui instancie une balle à chaque fois que l'on appuie sur "Espace". Les balles se détruisent après 2s (script sur la balle)  
**Partie 24 : Arrays** => Création d'un GameObject appelé "Array" avec un script qui créer un tableau de GameObjects, et dans le Start(), on l'initialise en mettant tous les GameObjects ayant le tag "Player" (ici l'arbre et le pistolet), et on l'affiche dans la console.  
**Partie 25 : Invoke** => Création d'un GameObject appelé "Invoke" avec un script qui créer une douille de balle toutes les 2 secondes au niveau du pistolet, elles se détruisent après 2s. Appuyer sur "K" pour stopper l'invoke.  
**Partie 26 : Enumerations** => Vidéo qui explique comment déclarer les types enumérés. Rien de nouveau ici, aucun ajout.  
**Partie 27 : Switchs** => Vidéo qui explique le switch, similaire au JS. Rien de nouveau également, aucun ajout.  
  
###########################################################################################    
  
**19/07**  
  
Module 1 : Roll-a-ball

=> Réalisation, en suivant le tutoriel, d'un mini-jeu où on contrôle une balle à l'aide des flèches du clavier ou W,A,S,D et où on peut récupérer des cubes, avec un message de fin
Le tout à été réalisé en utilisant seulement des objets déjà présents dans Unity (cube, sphère..)
Bien évidemment, les scripts ont été donnés dans le cours, mais cela permet de comprendre comment les écrire de A à Z correctement, comment on peut lier des objets entre eux grâce aux scripts, intéragir entre eux..
