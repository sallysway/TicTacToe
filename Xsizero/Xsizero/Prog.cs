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
            {"o","1","2"},
            {"3","4","5"},
            {"6","7","8"}
        };

        public bool CheckHorizontal()
        {
            for (int row = 0; row < 3; row++)
                if (Grid[row, 0] == Grid[row, 1] && Grid[row, 1] == Grid[row, 2])
                    return true;
            return false;
        }

        public bool CheckVertical()
        {
            for (int column = 0; column < 3; column++)
            {
                if (Grid[0, column] == Grid[1, column] && Grid[1, 0] == Grid[2, column])
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckGameWon()
        {
            if ((CheckHorizontal()) || (CheckVertical()) || (CheckIfDiagonal()))
            {
                return true;
            }
            return false;
        }

        public bool CheckIfDiagonal()
        {
            if ((Grid[0, 0] == Grid[1, 1] && Grid[1, 1] == Grid[2, 2]) ||
                (Grid[2, 0] == Grid[1, 1] && Grid[1, 1] == Grid[0, 2]))
            {
                return true;
            }
            return false;
        }

        public string[,] Play(string symbol, int y, int x)
        {
            if (Grid[y, x] != "X" && Grid[y, x] != "0")
            {
                Grid[y, x] = symbol;
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