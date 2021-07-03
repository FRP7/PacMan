using System;
using System.Collections.Generic;
using System.Text;
using PacMan.GameLoopStuff;

namespace PacMan.GameToolsStuff
{
    /// <summary>
    /// Control the game.
    /// </summary>
    public class GameController
    {
        /// <summary>
        /// Access the GameLoop class.
        /// </summary>
        private GameLoop gameLoop;

        /// <summary>
        /// Play the game.
        /// </summary>
        public void PlayGame()
        {
            gameLoop.Game();
        }

        /// <summary>
        /// GameController constructor.
        /// </summary>
        public GameController()
        {
            gameLoop = new GameLoop();
        }
    }
}
