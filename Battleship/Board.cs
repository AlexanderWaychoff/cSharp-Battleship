using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Board
    {
        List<List<string>> gameBoard = new List<List<string>>();
        private int loopValue;
        public Board()
        {
            this.boardAssembly();
        }
        public List<List<string>> boardAssembly()
        {
            List<string> alphaChar = new List<string>() { "//", "A|", "B|", "C|", "D|", "E|", "F|", "G|", "H|", "I|", "J|" };
            List<string> fillBoard = new List<string>(); //{ "~", "~", "~", "~", "~", "~", "~", "~", "~", "~"};
            gameBoard.Add(alphaChar);
            for (int i = 1; i <= 10; i++)
            {
                gameBoard.Add(fillBoard);
                loopValue = i;
                gameBoard[i].Add(i.ToString() + ".");
                for (int j = 1; j <= 10; j++)
                {
                    gameBoard[i].Add("~|");
                }
                fillBoard = new List<string>();
            } 
            return gameBoard;
        }
        public List<List<string>> DisplayBoard()
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    if (gameBoard[j][i] == "~|")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if (gameBoard[j][i] == "//")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    Console.Write(gameBoard[j][i]);
                }
                Console.WriteLine();
            }
            Console.ResetColor();
            return gameBoard;
        }
    }
}
