using System;
using System.Collections.Generic;
using System.Text;
using PacMan.GameObjectsStuff;
using PacMan.GameObjectsStuff.Levels;
using PacMan.GameObjectsStuff.Player;

namespace PacMan.GameToolsStuff
{
    /// <summary>
    /// Keep important data of the game.
    /// </summary>
    public static class GameData
    {
        private static GameObject[] gameObject = { new Level1(), new Pac() };

        public static GameObject[] GameObjects => gameObject;

        private static int playerX;
        private static int playerY;

        public static int PlayerX
        {
            get => playerX;
            set => playerX = value;
        }
        public static int PlayerY
        {
            get => playerY;
            set => playerY = value;
        }

        public static Dir PlayerDirection { get; set; }
    }
}
