using System;
using PacMan.GameToolsStuff;

namespace PacMan
{
    /// <summary>
    /// Main class of the game.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Play the game.
        /// </summary>
        /// <param name="args"> Arguments.</param>
        public static void Main(string[] args)
        {
            GameController gameController = new GameController();

            gameController.PlayGame();
        }
    }
}
