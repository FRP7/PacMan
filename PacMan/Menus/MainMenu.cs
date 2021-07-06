using System;
using System.Collections.Generic;
using System.Text;
using PacMan.GameToolsStuff;

namespace PacMan.Menus
{
    public class MainMenu
    {
        private GameController gameController;

        public void RunMenu()
        {
            MenuOptions();
        }

        private void MenuOptions()
        {
            Console.Clear();

            string userChoice;

            Console.WriteLine("\t\t\t\t__________                    _____                 ");
            Console.WriteLine("\t\t\t\t" + @"\______   \_____    ____     /     \ _____    ____  ");
            Console.WriteLine("\t\t\t\t" + @" |     ___/\__  \ _/ ___\   /  \ /  \\__  \  /    \ ");
            Console.WriteLine("\t\t\t\t" + @" |    |     / __ \\  \___  /    Y    \/ __ \|   |  \");
            Console.WriteLine("\t\t\t\t" + @" |____|    (____  /\___  > \____|__  (____  /___|  /");
            Console.WriteLine("\t\t\t\t" + @"                \/     \/          \/     \/     \/ ");

            Console.WriteLine("\n\n\t\t\t\t\t\t       1) PLAY");
            Console.WriteLine("\n\t\t\t\t\t\t    2) INSTRUTIONS");
            Console.WriteLine("\n\t\t\t\t\t\t      3) SCORES");
            Console.WriteLine("\n\t\t\t\t\t\t      4) CREDITS");
            Console.WriteLine("\n\t\t\t\t\t\t       5) EXIT");

            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Console.Clear();
                gameController.PlayGame();
            }
            else if (userChoice == "2")
            {
                Instructions();
            }
            else if (userChoice == "3")
            {
                Scores();
            }
            else if (userChoice == "4")
            {
                Credits();
            }
            else if (userChoice == "5")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
            }
        }

        private void Instructions()
        {
            string userChoice;

            Console.Clear();
            Console.WriteLine("Instructions page");
            Console.WriteLine("Insert instructions.");
            Console.WriteLine("Click 1 to return.");

            userChoice = Console.ReadLine();

            if(userChoice == "1")
            {
                MenuOptions();
            }
        }

        private void Scores()
        {
            string userChoice;

            Console.Clear();
            Console.WriteLine("Scores page");
            Console.WriteLine("Insert score.");
            Console.WriteLine("Click 1 to return.");

            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                MenuOptions();
            }
        }

        private void Credits()
        {
            string userChoice;

            Console.Clear();
            Console.WriteLine("Credits page");
            Console.WriteLine("Insert credits.");
            Console.WriteLine("Click 1 to return.");

            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                MenuOptions();
            }
        }

        public MainMenu()
        {
            gameController = new GameController();
        }
    }
}
