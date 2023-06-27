// Combien de jeune ?
int age = 20;


int[] personneJeune = StringToArray(" 15 5 5 6 4 2 11 16 7 8 7 3 13 16 11 18 8 9 19 3 ".Trim());
int[] personneVieux = StringToArray(" 45 35 65 76 34 20 20 30 30 30 20 20 30 20 30 20 20 8 15 23 ".Trim());
int[] personneVingth = StringToArray(" 20 20 20 20 20 20 20 20 ".Trim());
//Console.Write($"Il y a {CombienDeJeune(personneJeune,age)} personne(s) de moins de 20 ans");
int[] compteur = CombienDeGens(personneJeune , age);
ShowPeople(compteur);
 compteur = CombienDeGens(personneVieux, age);
ShowPeople(compteur);
compteur = CombienDeGens(personneVingth, age);
ShowPeople(compteur);

static int[] StringToArray(string valeurs)
{
    string[] arrayString = valeurs.Split(" ");
    int[] arrayToReturn = new int[arrayString.Length];

    for (int i = 0; i < arrayString.Length; i++)
    {
        arrayToReturn[i] = int.Parse(arrayString[i]);
    }

    return arrayToReturn;
}

static int CombienDeJeune(int[] personneJeune, int age)
{
    int compteur = 0;

    for (int i = 0; i < personneJeune.Length; i++)
    {
        if (personneJeune[i] < age)
        {
            Console.Write(personneJeune[i] + " ");
            compteur++;
        }
    }
    Console.WriteLine();
    return compteur;
}

static int[] CombienDeGens(int[] personneJeune, int age)
{
    int[] compteur = new int[] {0,0,0};

    for (int i = 0; i < personneJeune.Length; i++)
    {
        if (personneJeune[i] > age)
        {
            compteur[0]++;
        }
        else if (personneJeune[i] < age)
        {
            compteur[1]++;
        }
        else
        {
            compteur[2]++;
        }
    }
    return compteur;
}

static void ShowPeople(int[] _array)
{
    if (_array[0]==0)
    {
        Console.WriteLine("Ya que des ieuv");
    }
    else if (_array[1]==0)
    {
        Console.WriteLine("Ya que des djeuns");
    }
    else if(_array[2] == 0)
    {

    }
    else
    {
        Console.WriteLine("tlm a 20 ans");
    }
}

/*Exercice 5.3.1 : Calculer le nombre de jeunes.
 * 
Il s'agit de dénombrer toutes les personnes d'âge strictement inférieur à 20 ans parmi un échantillon de 20 personnes. 
L’utilisateur est invité à saisir les 20 valeurs.

Décrivez l'algorithme qui affiche le nombre de jeunes et codez la solution.
*/

/* VOIR POUR UTILISATION DE LISTES OU TABLEAUX.
List<int> groupePasJeune = new List<int>() { 45, 35, 65, 76, 34, 32, 31, 46, 57, 68, 75, 46, 53, 36, 31, 46, 68, 59, 30, 20 };
List<int> groupeJeune = new List<int>() { 15, 5, 5, 6, 4, 2, 11, 16, 7, 8, 7, 3, 13, 16, 11, 18, 8, 9, 19, 3 };
List<int> groupeMixte = new List<int>() { 45, 35, 65, 76, 34, 20, 20, 30, 30, 30, 20, 20, 30, 20, 30, 20, 20, 8, 15, 23 };
*/

// test list.

List<string> maListe = new List<string> { "Mathieu", "Rody", "Nico", "Gg", "L'intru" };
foreach (string name in maListe)
{
    /* Les 3 version font la même chose.
     * le $ a son importance! ne pas l'oublier.
     * Sinon obligé de faire V3.
     */

    //Console.WriteLine($"Bonjour {name.ToUpper()}!"); //V1 ToUpper affiche les noms en MAJUSCULE.
    Console.Write($"Bonjour {name}, "); //V2
    //Console.Write("{0}{1}{2}"," Bonjour, ",name," salut !"); //V3 Les {} définissent les positions des paramètres.
    //Console.WriteLine("Bonjour " +name+" !"); //V4

}
// Je supprime l'intru et ajoute Gatien et johnny
Console.WriteLine("\n");
maListe.Add("Gatien");
maListe.Add("Johnny");
maListe.Remove("L'intru");
foreach (string name in maListe)
{
    Console.Write($"Bonjour {name}, ");
}

// j'utilise la reference de la position dans la Liste --> [x]
Console.WriteLine();
Console.Write($"Mon prénom est: {maListe[0]}. \n");
Console.Write($"J'ai ajouté: {maListe[4]} and {maListe[5]} à la liste \n");



//Je verifie la taille de ma liste.
Console.Write($"La liste contient {maListe.Count} personnes. \n");


// TEST TRI TABLEAU
//creation du tableau de depart
int[] tableauAtrier = new int[] { 2, 10, 5, 8, 4, 11 };
Console.WriteLine("Array  Before Sorting:\n");
//affichage du tableau de depart avec boucle foreach
foreach (int value in tableauAtrier)
{
    Console.Write(value + " ");
}
Console.WriteLine("\n");

// TRI DU TABLEAU DANS L'ORDRE CROISSANT du +P --> +G.
Array.Sort(tableauAtrier);

Console.WriteLine("\n");

// AFFICHAGE du tableau 

foreach (int value in tableauAtrier)
{
    Console.Write(value + " ");
}

//AFFICHER le tableau sans foreach
Console.WriteLine(string.Join(",", tableauAtrier));


// Reverse inverse les valeurs du tableau pour avoir un tri en DECROISSANT du +G --> +P.
Array.Reverse(tableauAtrier);

Console.WriteLine("Array After Sorting:\n");
/*
foreach (int value in tableauAtrier)
{
    Console.Write(value + " ");
}
*/
//AFFICHER le tableau sans foreach
Console.WriteLine();
Console.WriteLine(string.Join(",", tableauAtrier));

static int[] StringToArray(string valeurs)
{
    string[] arrayString = valeurs.Split(" ");
    int[] arrayToReturn = new int[arrayString.Length];

    for (int i = 0; i < arrayString.Length; i++)
    {
        arrayToReturn[i] = int.Parse(arrayString[i]);
    }

    return arrayToReturn;
}