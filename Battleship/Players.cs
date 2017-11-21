using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Players
    {
        AttackBoard attackBoard = new AttackBoard();
        ShipPlacementBoard shipPlacementBoard = new ShipPlacementBoard();

        private string destroyerVH;
        private string destroyerLetterPlacement;
        private string destroyerNumberPlacement;
        private string playerInput;
        private bool checkCorrectInput = false;
        public void players()
        {
            
        }
        public void placeDestroyer()
        {
            shipPlacementBoard.DisplayBoard();
            //string check1 = "v";
            //string check2 = "h";
            Console.WriteLine("\n\n**Place your destroyer**\n\nThe Destroyer is a ship that is 2 spots long.");
            destroyerVH = VerifyVHInput("\nWould you like to place your ship vertically or horizontally?  Type 'v' for vertical, or 'h' for horizontal.");//, check1, check2);
            destroyerLetterPlacement = VerifyAlphabeticalInput("\n\nYou are placing your Destroyer " + destroyerVH + ".  From which letter would you like to place your ship? (The bottom/left of the ship will start on this letter; pick a letter that won't cause the ship to go above 'A'.");
            destroyerNumberPlacement = VerifyNumericalInput("Last, which number would you like to place your Destroyer? (The bottom/left of the ship will start on this number; pick a number that won't cause the ship to go past '10.'.");
            shipPlacementBoard.PlaceDestroyer(destroyerVH, destroyerLetterPlacement, destroyerNumberPlacement);
        }

        private string VerifyNumericalInput(string question)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            checkCorrectInput = false;
            do
            {
                if (checkCorrectInput)
                {
                    Console.WriteLine("\n**Your input wasn't valid, please type exactly as indicated.**\n");
                }
                Console.WriteLine(question);
                playerInput = Console.ReadKey().Key.ToString().ToLower();
                Console.Clear();
                checkCorrectInput = true;
            }
            while (!(playerInput == "1" || playerInput == "2" || playerInput == "3" || playerInput == "4" || playerInput == "5" || playerInput == "6" || playerInput == "7" || playerInput == "8" || playerInput == "9" || playerInput == "10"));
            Console.Clear();
            Console.ResetColor();
            return playerInput;
        }

        public string VerifyVHInput(string question)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            checkCorrectInput = false;
            do
            {
                if (checkCorrectInput)
                {
                    Console.WriteLine("\n**Your input wasn't valid, please type exactly as indicated.**\n");
                }
                Console.WriteLine(question);
                playerInput = Console.ReadKey().Key.ToString().ToLower();
                Console.Clear();
                checkCorrectInput = true;
            }
            while (!(playerInput == "v" || playerInput == "h"));
            if (playerInput == "v")
            {
                playerInput = "vertical";
            }
            else
            {
                playerInput = "horizontal";
            }
            Console.Clear();
            Console.ResetColor();
            return playerInput;
        }
        public string VerifyAlphabeticalInput(string question)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            checkCorrectInput = false;
            do
            {
                if (checkCorrectInput)
                {
                    Console.WriteLine("\n**Your input wasn't valid, please type exactly as indicated.**\n");
                }
                Console.WriteLine(question);
                playerInput = Console.ReadKey().Key.ToString().ToLower();
                Console.Clear();
                checkCorrectInput = true;
            }
            while (!(playerInput == "a" || playerInput == "b" || playerInput == "c" || playerInput == "d" || playerInput == "e" || playerInput == "f" || playerInput == "g" || playerInput == "h" || playerInput == "i" || playerInput == "j"));
            Console.Clear();
            Console.ResetColor();
            return playerInput;
        }
        //public bool verticalH(string question, string inputV, string inputH)
        //{
        //    Console.WriteLine(question);
        //    string userInput = Console.ReadKey().KeyChar.ToString();
        //    if (inputV == "v" || inputH == "h")
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
