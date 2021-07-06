using System;
using System.Collections.Generic;
using System.Text;
using PacMan.GameLoopStuff;
using PacMan.GameToolsStuff;

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
            GameData.Level1Score = 0;
            GameData.IsGameOver = false;
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
