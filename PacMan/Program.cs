using System;
using PacMan.GameToolsStuff;
using PacMan.Menus;

namespace PacMan
{
    /// <summary>
    /// Main class of the game.
    /// </summary>
    public class Program
    {
        private static MainMenu mainMenu;

        /// <summary>
        /// Play the game.
        /// </summary>
        /// <param name="args"> Arguments.</param>
        public static void Main(string[] args)
        {
            mainMenu = new MainMenu();

            mainMenu.RunMenu();
        }
    }
}
