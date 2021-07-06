using System;
using System.Collections.Generic;
using System.Text;
using PacMan.Menus;
using PacMan.GameToolsStuff;

namespace PacMan.Menus
{
    public class EndMenu
    {
        private GameController gameController;
        private MainMenu mainMenu;

        public void RunMenu()
        {
            MenuOptions();
        }

        private void MenuOptions()
        {
            string userInput;

            Console.Clear();
            Console.WriteLine("End game menu,");
            Console.WriteLine("Insert text.");
            Console.WriteLine("1) Restart the game.");
            Console.WriteLine("2) Go to main menu.");
            Console.WriteLine("3) Exit game.");

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
            }
        }

        public EndMenu()
        {
            gameController = new GameController();
            mainMenu = new MainMenu();
        }
    }
}
