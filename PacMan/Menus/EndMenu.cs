using System;
using System.Collections.Generic;
using System.Text;
using PacMan.Menus;
using PacMan.GameToolsStuff;

namespace PacMan.Menus
{
    public class EndMenu : IMenu
    {
        private GameController gameController;
        private MainMenu mainMenu;

        private readonly bool isLost;

        public void RunMenu()
        {
            MenuOptions();
        }

        private void MenuOptions()
        {
            string userInput;

            bool shut = false;

            Console.Clear();

            if (isLost)
            {
                Console.WriteLine("\n\n\t\t\t\t\t\t       GAME OVER!");
            }
            else
            {
                Console.WriteLine("\n\n\t\t\t\t\t\t       GAME WON!");
            }
            Console.WriteLine("\n\n\t\t\t\t\t\t      1) RESTART");
            Console.WriteLine("\n\t\t\t\t\t\t      2) MAIN MENU");
            Console.WriteLine("\n\t\t\t\t\t\t      3) EXIT");

            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.Clear();
                gameController.PlayGame();
            }
            else if (userInput == "2")
            {
                Console.Clear();
                mainMenu.RunMenu();
            }
            else if (userInput == "3")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                //Console.WriteLine("Try again!");
            }
        }

        public EndMenu(bool lost)
        {
            gameController = new GameController();
            mainMenu = new MainMenu();
            isLost = lost;
        }
    }
}
