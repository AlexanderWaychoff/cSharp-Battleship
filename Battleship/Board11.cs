using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Board11
    {
        List<List<string>> gameBoard = new List<List<string>>();
        private int loopValue;
        public void board()
        {

        }
        public List<List<string>> arrayBoard()
        {
            //List<List<string>> board = new List<List<string>>();
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
            //for(int i = 0; i <= 10; i++)
            //{
            //foreach (var item in gameBoard[0])
            //{
            //        Console.Write(item);
            //        for (int i = 1; i <= 10; i++)
            //    {


            //            Console.Write(gameBoard[i]);

            //        if(i == 10)
            //        {
            //            Console.Write("\n");
            //        }
            //    }
            //}
            //}
            //DisplayBoard(gameBoard);
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.Write(gameBoard[j][i]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            return gameBoard;
        }
        //public void DisplayBoard<T>(T[,] gameBoard)
        //{            
        //    for (int i = 0; i < gameBoard.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < gameBoard.GetLength(1); j++)
        //        {
        //            Console.Write(gameBoard[i, j] + "\t");
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}
