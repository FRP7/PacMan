using System;
using System.Collections.Generic;
using System.Text;

namespace PacMan.GameLoop
{
    /// <summary>
    /// Control the game.
    /// </summary>
    public class GameController
    {
        private GameLoop gameLoop;

        public void PlayGame()
        {
            gameLoop.Game();
        }

        public GameController()
        {
            gameLoop = new GameLoop();
        }
    }
}
