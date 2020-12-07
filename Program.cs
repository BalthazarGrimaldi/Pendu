using System;

namespace Pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            Grille myGrid = new Grille();

            myGrid.ModifyGrid(12);
            myGrid.displayGrid();
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