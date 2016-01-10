using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsizero
{
    class TicTacToe
    {
        private static string[,] Grid =
        {
            {"0","1","2"},
            {"3","4","5"},
            {"6","7","8"}
        };

        public bool CheckHorizontal()
        {
            if ((Grid[0, 0] == Grid[0, 1] && Grid[0, 1] == Grid[0, 2]) ||
               (Grid[1, 0] == Grid[1, 1] && Grid[1, 1] == Grid[1, 2]) ||
               (Grid[2, 0] == Grid[2, 1] && Grid[2, 1] == Grid[2, 2]))
            {
                Console.WriteLine("Won horizontally");
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckVertical()
        {
            if ((Grid[0, 0] == Grid[1, 0] && Grid[1, 0] == Grid[2, 0]) ||
                    (Grid[0, 1] == Grid[1, 1] && Grid[1, 1] == Grid[2, 1]) ||
                    (Grid[0, 2] == Grid[1, 2] && Grid[1, 2] == Grid[2, 2]))
            {
                Console.WriteLine("Won vertically");
                Console.ReadLine();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckIfGameWon()
        {
            bool hor = CheckHorizontal();
            bool ver = CheckVertical();
            if (!hor && !ver)
            {
                if ((Grid[0, 0] == Grid[1, 1] && Grid[1, 1] == Grid[2, 2]) ||
                    (Grid[2, 0] == Grid[1, 1] && Grid[1, 1] == Grid[0, 2]))
                {
                    Console.WriteLine("Game won");
                    Console.ReadLine();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public string[,] Play(string symbol, int y, int x)
        {
            bool won = CheckIfGameWon();
            if (!won)
            {
                if (Grid[y, x] != "X" && Grid[y, x] != "0")
                {
                    Grid[y, x] = symbol;
                }
            }
            else
            {
                Console.WriteLine("Please start a new game");
            }
            return Grid;
        }

        public void ShowBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                Console.WriteLine("{0}    {1}    {2}\n", Grid[row, 0], Grid[row, 1], Grid[row, 2]);
            }
            Console.WriteLine("***********************************************************");
            Console.ReadLine();
        }
    }
}
