using System;
using System.Text;
using System.Xml;
namespace Pendu
{
    class Jeu
    {
        public Jeu() { }
        public void play()
        {
            /*String[] listeMot = new string[2];
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("D:\\Cours\\Ecole\\3ème année\\Cours informatique\\Cours Joan C#\\pendu\\Dictionaire.xml");
            foreach (XmlNode xmlNode in xmlDoc.DocumentElement)
                Console.WriteLine(xmlNode.Attributes["mot"].Value + ": " + xmlNode.Attributes["nb"].Value);
            Console.ReadKey();*/
            Mot leMot = new Mot("anticonstitutionnellement");
            Grille myGrid = new Grille();
            String value = "";
            String motLettre = "";
            char i;
            int pointMalus = 0;
            String difficulty = "";
            String choixMotLettre = "";
            while (difficulty != "facile" && difficulty != "moyen" && difficulty != "difficile")
            {
                Console.WriteLine("Choisisez l'un des trois niveaux de difficultés (facile/moyen/difficile)");
                difficulty = Console.ReadLine();
            }
            Console.WriteLine(leMot.MotTrou);
            Console.WriteLine($"Vous avez {leMot.NbMotTrou} lettres à trouver");
            while (!myGrid.isLoose() && !leMot.isWin())
            {
                /*
                while (choixMotLettre != "lettre" && choixMotLettre != "mot")
                {
                    Console.WriteLine("Veuillez choisir si vous preférez tanter de deviner le mot ou si voulez proposez une lettre (lettre/mot)");
                    motLettre = Console.ReadLine();
                }
                if (choixMotLettre == "lettre")
                {
                    while (value.Length != 1)
                    {
                        Console.WriteLine("Donnez une lettre !");
                        value = Console.ReadLine();
                    }
                    value = value.ToUpper();
                    i = System.Convert.ToChar(value);
                    value = "";
                    if (!leMot.trouverLettre(i))
                    {
                        pointMalus = myGrid.difficultyToPoint(difficulty, pointMalus);
                    }
                    Console.WriteLine("---------------------------------------------------------------");
                    Console.WriteLine($" Vous venez de jouer : {leMot.Lettre}");
                    Console.WriteLine($"Erreurs : {string.Join(" ", leMot.Lettres)}");
                    myGrid.modifyGrid(pointMalus);
                    myGrid.displayGrid();
                    if (leMot.NbMotTrou == 1)
                    {
                        Console.WriteLine("Il reste une seule lettre à trouver, vous y êtes presque !");
                    }
                    else if (leMot.NbMotTrou == 0)
                    {
                        Console.WriteLine("Il ne reste plus de lettre à trouver !!");
                    }
                    else
                    {
                        Console.WriteLine($"Il vous reste {leMot.NbMotTrou} lettres à trouver");
                    }
                    Console.WriteLine(leMot.MotTrou);
                }
                */
                while (value.Length != 1)
                {
                    Console.WriteLine("Donnez une lettre !");
                    value = Console.ReadLine();
                }
                value = value.ToUpper();
                i = System.Convert.ToChar(value);
                value = "";
                if (!leMot.trouverLettre(i))
                {
                    pointMalus = myGrid.difficultyToPoint(difficulty, pointMalus);
                }
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine($" Vous venez de jouer : {leMot.Lettre}");
                Console.WriteLine($"Erreurs : {string.Join(" ", leMot.Lettres)}");
                myGrid.modifyGrid(pointMalus);
                myGrid.displayGrid();
                if (leMot.NbMotTrou == 1)
                {
                    Console.WriteLine("Il reste une seule lettre à trouver, vous y êtes presque !");
                }
                else if (leMot.NbMotTrou == 0)
                {
                    Console.WriteLine("Il ne reste plus de lettre à trouver !!");
                }
                else
                {
                    Console.WriteLine($"Il vous reste {leMot.NbMotTrou} lettres à trouver");
                }
                Console.WriteLine(leMot.MotTrou);

            }
            if (myGrid.isLoose())
            {
                Console.WriteLine("Vous avez perdus !!");
            }
            else
            {
                Console.WriteLine("Vous avez gagné !!");
            }
        }
    }
}