using System;

namespace Pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            Mot leMot = new Mot("saperlipopette");
            Grille myGrid = new Grille();
            String value = "";
            char i;
            int pointMalus = 0;
            String difficulty = "";
            while (difficulty != "facile" && difficulty != "moyen" && difficulty != "difficile")
            {
                Console.WriteLine("Choisisez l'un des trois niveaux de difficultés (facile/moyen/difficile)");
                difficulty = Console.ReadLine();
            }
            Console.WriteLine(leMot.MotTrou);
            while (!myGrid.isLoose() && !leMot.isWin())
            {
                while (value.Length != 1)
                {
                    Console.WriteLine("Donnez une lettre !");
                    value = Console.ReadLine();
                }
                i = System.Convert.ToChar(value);
                value = "";
                if (!leMot.trouverLettre(i))
                {
                    pointMalus = myGrid.difficultyToPoint(difficulty, pointMalus);
                }
                myGrid.modifyGrid(pointMalus);
                myGrid.displayGrid();
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

/*

 String a = "Joseph Staline";
            char[] x = a.ToCharArray(0, a.Length);
            foreach (var sub in x)
            {
                Console.WriteLine($"Substring: {sub}");
            }
   ______
  |     |
  |     O
  |    /|\
  |    / \
__|__     

*/