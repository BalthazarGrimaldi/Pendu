using System;

namespace Pendu
{
    class Grille
    {
        private char[,] grid = new char[,] {
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' }

            };
        public void displayGrid()
        {
            for (int i = 0; i < this.grid.GetLength(0); i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                for (int j = 0; j < this.grid.GetLength(1); j++)
                {
                    Console.Write(this.grid[i, j]);
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("\n");
            }
        }

        public void toModifyGrid(int y, int x, char trait, int number)
        {
            if (number > 0)
            {
                this.grid[y, x] = trait;
            }
        }

        public void modifyGrid(int number)
        {
            int for1 = number;
            if (number > 4)
            {
                for1 = 4;
            }
            for (int i = 1; i < for1 + 1; i++)
            {
                this.grid[7, i] = '_';
            }
            number = number - 4;
            for (int i = 7; i > 2; i--)
            {
                if (number <= 0)
                {
                    break;
                }
                number = number - 1;
                this.grid[i, 2] = '|';
            }
            int for3 = number;
            if (number > 4)
            {
                for3 = 4;
            }
            for (int i = 3; i < for3 + 3; i++)
            {
                this.grid[2, i] = '_';
            }
            number = number - 4;

            toModifyGrid(3, 7, '|', number);
            toModifyGrid(4, 7, 'o', number - 1);
            toModifyGrid(5, 7, '|', number - 2);
            toModifyGrid(5, 6, '/', number - 3);
            toModifyGrid(5, 8, '\\', number - 4);
            toModifyGrid(6, 6, '/', number - 5);
            toModifyGrid(6, 8, '\\', number - 6);
        }

        public bool isLoose()
        {
            if (this.grid[6, 8] == '\\')
            {
                return true;
            };
            return false;
        }

        public int difficultyToPoint(String difficulty, int pointMalus)
        {
            if (difficulty == "facile")
            {
                pointMalus++;
            }
            else if (difficulty == "moyen")
            {
                pointMalus += 2;
            }
            else
            {
                pointMalus += 3;
            }
            return pointMalus;
        }

    }

}