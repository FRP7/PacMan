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
        /// <summary>
        /// GameObjects in the game.
        /// </summary>
        private static GameObject[] gameObject = { new Level1(), new Pac() };

        /// <summary>
        /// Gets the gameobjects.
        /// </summary>
        public static GameObject[] GameObjects => gameObject;

        /// <summary>
        /// Player's x coordinate.
        /// </summary>
        private static int playerX;

        /// <summary>
        /// Player's y coordinate.
        /// </summary>
        private static int playerY;

        /// <summary>
        /// Gets or sets player's x coordinate.
        /// </summary>
        public static int PlayerX
        {
            get => playerX;
            set => playerX = value;
        }

        /// <summary>
        /// Gets or sets player's y coordinate.
        /// </summary>
        public static int PlayerY
        {
            get => playerY;
            set => playerY = value;
        }

        /// <summary>
        /// Gets or sets the player's direction.
        /// </summary>
        public static Dir PlayerDirection { get; set; }
    }
}
