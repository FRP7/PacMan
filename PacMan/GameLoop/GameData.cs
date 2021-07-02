using System;
using System.Collections.Generic;
using System.Text;
using PacMan.GameObjects;

namespace PacMan.GameLoop
{
    /// <summary>
    /// Keep important data of the game.
    /// </summary>
    public static class GameData
    {
        private static GameObject[] gameObject = { new GameScene() };

        public static GameObject[] GameObjects => gameObject;
    }
}
