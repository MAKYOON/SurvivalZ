#LI KEVIN  
#Cours : Beginner Scripting  
  
**28/11**  
  
**Certification Unity** : ayant d�j� r�alis� ce cours, j'ai re-git tel quel comme je l'avais fais � l'�poque, mais j'en ai profit� pour  
regarder � nouveau ce qu'il �tait demand� de faire, et en reprenant les choses � voir.
  
**30/07**  
  
Module 4 : Recorded Video Session: Text Adventure Game Part 2  
  
=> R�alisation de la Partie 2 de la s�rie de vid�os sur le Text Adventure Game. J'ai publi� le projet Unity fini : les scripts sont identiques � ceux dans les vid�os, j'ai simplement fait un mini-jeu en fran�ais  
Actions possibles : aller (nord, est, sud, ouest) / examiner (�p�e, chaines) / prendre (�p�e) / utiliser (�p�e)  
Le principal dans cette s�rie de vid�os �tait vraiment l'utilisations des listes, du dictionnaire, des classes abstraites et les h�ritages, des notions plus approffondies en C#  
  
###########################################################################################  
  
**26/07**  
  
Module 3 : Recorded Video Session: Text Adventure Game Part 1  
  
=> R�alisation de la Partie 1 de la s�rie de vid�os sur le Text Adventure Game. Cela nous permet d'apprendre des notions suppl�mentaires : le type "Scriptable Object" qui ne s'attache pas � un GameObject comme le MonoBehaviour, et permet de contenir du code et de l'ex�cuter quando on le souhaite  
On a pu �galement voir l'utilisations des listes, du dictionnaire, des classes abstraites et les h�ritages
Pour l'instant je n'ai pas commit le projet Unity, je le publierais une fois la partie 2 termin�e.
  
###########################################################################################  

**24/07**

Module 2 : Beginner Scripting

**Partie 1 : Scripts as Behaviour Components** => Ecriture d'un script qui active la gravit� du cube lorsqu'on appuie sur "1"  
**Partie 2 : Variables and Functions** => Cr�ation d'une variable "myMass" initialis�e � 100, et cr�ation de la fonction "changeMass" qui, lorsqu'on appuie sur "2", modifie la masse du cube � "myMass" donc 100  
**Partie 3 : Conventions and Syntax** => Rien de nouveau sur cette vid�o, du coup je n'ai rien rajout�  
**Partie 4 : IF Statements** => Rajout d'un "if" dans le script, qui indique que si la masse du cube est �gale � 100, on d�sactive le "Collider" du cube  
**Partie 5 : Loops** => Test des boucles "While", "DoWhile" et "For". Rien de nouveau en soi, pour les tester, voir le GameObject "TestingLoops" et les activer 1 par 1, le r�sultat est dans la console  
**Partie 6 : Scope and Access Modifiers** => Vid�o expliquant la port�e des variables, et la notion de "public" et "private". Ici, j'ai juste rajout� un script avec une variable public, qui s'affiche dans la console (et que l'on peut modifier � travers l'inspecteur du coup) sur la Sph�re  
**Partie 7 : Awake and Start** => Vid�o qui explique la diff�rence entre la fonction Awake() et Start(), Awake est appel�e d�s le lancement du jeu, peu importe si le GameObject est initialis� ou non, alors que Start n'est appel� que lorsque le GameObject est initialis�. Je n'ai rien rajout� dans le projet  
**Partie 8 : Update and FixedUpdate** => Vid�o qui explique la diff�rence entre la fonction Update() et FixedUpdate() : Update() est appel� � chaque frame, mais �a peut �tre inconsistant car si les frames sont d�cal�es dans le temps, alors les actions le seront �galement. FixedUpdate est appel� � un temps fixe et est ind�pendant. FixedUpdate est en g�n�ral utilis� pour bouger un GameObject qui poss�de un Rigidbody, en y appliquant des forces. Update peut servir � faire de simple timers, r�cup�rer les inputs, bouger des objets non-physiques..  
**Partie 9 : Vector Maths** => Vid�o rappel sur les vecteurs. J'ai cr�er un script sur un GameObject appel� "VectorScripts" dans lequel j'ai cr�er 2 vecteurs A et B, et o� j'ai calcul� la magnitude d'un vecteur, la somme,soustraction, multiplication par un scalaire, produit scalaire et produit vectoriel entre les deux vecteurs. Note : pour la multiplication par un scalaire, j'ai cr�er une variable publique "My Scalaire" que l'on peut modifier avant de lancer la sc�ne.  
**Partie 10 : Enabling and Disabling Components** => Cr�ation d'un script sur la Sph�re, j'y ai rajout� une "Light". En appuyant sur la touche "3" on disable la "Light" (peut se voir dans la sc�ne : la face en bas du cube qui �tait blanche devient sombre)  
**Partie 11 : Activating GameObjects** => Sur la m�me Sph�re et dans le m�me script, j'ai rajout� le fait que si on appuie sur la touche "4", cela d�sactive la Sph�re.  
**Partie 12 : Translate and Rotate** => Vid�o qui explique les fonctions transform.Translate et transform.Rotate, ici j'ai juste rajout� un arbre et j'ai copi�/coll� le script donn� (permet de changer l'angle avec fl�che gauche/droite, et d'avancer reculer avec fl�che haut/bas)  
**Partie 13 : Look At** => Cr�ation d'un script sur la cam�ra, qui utilise la fonction transform.LookAt et qui suit l'objet "Tree"  
**Partie 14 : Linear Interpolation** => Cours qui montre la fonction Lerp (utilisable avec les vecteurs, ou couleurs..) qui permet d'interpoler entre deux valeurs, selon le coefficient choisi.  
**Partie 15 : Destroy** => rajout d'un script sur "Tree", quand on appuie sur la touche "5" on d�truit l'objet "Plane" avec un d�lai de 2 secondes  
**Partie 16 : GetButton and GetKey** => Vid�o qui explique la diff�rence entre les deux : GetButton attend un string avec le nom exact du Bouton dans l'input manager, alors que GetKey ne r�pond qu'au code sp�cifique de la touche. Il est recommand� d'utiliser GetButton car on peut modifier les noms des boutons dans l'input manager.  
**Partie 17 : GetAxis** => Vid�o qui explique le fonctionnement de GetAxis : cela retourne une valeur comprise entre -1 et 1. Lorsqu'on appuie sur une touche, on consid�rera du coup l'axe qui se d�placera de 0 � 1, puis de 1 � 0. De ce fait, la touche est toujours consid�r�e comme "up" m�me apr�s l'avoir relach�e. On peut g�rer la vitesse � laquelle l'axe se d�place, et revient. Pour tester, j'ai juste modifi� le script "TreeController", et en appuyant sur la fl�che de droite, on peut voir que le mouvement est diff�rent si on appuie plus ou moins sur la touche, que lorsque l'on se d�place � l'aide de la touche du bas (qui marche avec Input.GetKey)  
**Partie 18 : OnMouseDown** => Rajout dans le script "CubeScript" sur le "Cube" qui �crit dans la console "Test" lorsque l'on clique dessus  
**Partie 19 : GetComponent** => Vid�o qui montre comment utiliser GetComponent, et qui pr�cise qu'il faut l'utiliser le moins possible car c'est gourmand. On peut acc�der aux composants d'un objet, ou m�me au script d'un autre objet, et du coup � ses variables publiques �galement. Je n'ai rien rajout� ici  
**Partie 20 : DeltaTime** => Vid�o qui explique l'int�r�t de Time.deltaTime => sert surtout � fluidifier les mouvements. Entre autre, chaque frame n'est pas g�n�r�e exactement de la m�me mani�re et dans le m�me temps, il peut y avoir des �carts, et du coup provoquer une sacade dans le mouvement. Time.deltaTime permet d'ajuster ce probl�me en gardant un temps constant entre chaque it�ration, et avoir �galement une valeur en m/s au lieu de m/frame pour les vitesses. Aucun rajout ici.  
**Partie 21 : DataTypes** => Vid�o qui explique la diff�rence entre les variables de type "value" qui correspondent aux entiers, r�els, caract�re, chaine de caract�res, boolean, et structures, et les variables qui acc�dent � une r�f�rence gr�ce � leur adresse. Aucun rajout ici  
**Partie 22 : Classes** => Vid�o sur les classes, qui s'apparentent � des types structur�s, mais ce sont des mod�les : on peut cr�er des objets gr�ce aux constructeurs cr�er dans la class. Aucun rajout ici  
**Partie 23 : Instantiate** => J'ai import� un asset de pistolet et de balle, et cr�er un script qui instancie une balle � chaque fois que l'on appuie sur "Espace". Les balles se d�truisent apr�s 2s (script sur la balle)  
**Partie 24 : Arrays** => Cr�ation d'un GameObject appel� "Array" avec un script qui cr�er un tableau de GameObjects, et dans le Start(), on l'initialise en mettant tous les GameObjects ayant le tag "Player" (ici l'arbre et le pistolet), et on l'affiche dans la console.  
**Partie 25 : Invoke** => Cr�ation d'un GameObject appel� "Invoke" avec un script qui cr�er une douille de balle toutes les 2 secondes au niveau du pistolet, elles se d�truisent apr�s 2s. Appuyer sur "K" pour stopper l'invoke.  
**Partie 26 : Enumerations** => Vid�o qui explique comment d�clarer les types enum�r�s. Rien de nouveau ici, aucun ajout.  
**Partie 27 : Switchs** => Vid�o qui explique le switch, similaire au JS. Rien de nouveau �galement, aucun ajout.  
  
###########################################################################################    
  
**19/07**  
  
Module 1 : Roll-a-ball

=> R�alisation, en suivant le tutoriel, d'un mini-jeu o� on contr�le une balle � l'aide des fl�ches du clavier ou W,A,S,D et o� on peut r�cup�rer des cubes, avec un message de fin
Le tout � �t� r�alis� en utilisant seulement des objets d�j� pr�sents dans Unity (cube, sph�re..)
Bien �videmment, les scripts ont �t� donn�s dans le cours, mais cela permet de comprendre comment les �crire de A � Z correctement, comment on peut lier des objets entre eux gr�ce aux scripts, int�ragir entre eux..
