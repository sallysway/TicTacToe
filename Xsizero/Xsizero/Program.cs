using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsizero
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToe myGame = new TicTacToe();
            myGame.ShowBoard();
            myGame.Play("X", 1, 1);
            //myGame.ShowBoard();
            myGame.Play("X", 2, 1);
            //myGame.ShowBoard();
            myGame.Play("X", 0, 1);
            myGame.ShowBoard();
            //myGame.CheckIfGameWon();
            myGame.Play("0", 0, 0);
            myGame.Play("0", 1, 0);
            myGame.Play("0", 2, 0);
            myGame.CheckGameWon();
            myGame.ShowBoard();


        }
    }
}
