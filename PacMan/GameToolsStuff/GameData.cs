using System;
using System.Collections.Generic;
using System.Text;
using PacMan.GameObjectsStuff;
using PacMan.GameObjectsStuff.Levels;
using PacMan.GameObjectsStuff.Player;
using PacMan.GameObjectsStuff.Foods;
using PacMan.GameObjectsStuff.Ghosts;

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
        private static GameObject[] gameObject = { new Level1(), new Pac(),
            new FoodSpawner()};

        /// <summary>
        /// GameObjects in the game.
        /// </summary>
        private static GameObject[] ghosts = {new Ghost(39, 23)};

        /// <summary>
        /// Gets the gameobjects.
        /// </summary>
        public static GameObject[] GameObjects => gameObject;

        /// <summary>
        /// Gets the gameobjects.
        /// </summary>
        public static GameObject[] Ghosts => ghosts;

        /// <summary>
        /// List of tiles in level 1.
        /// </summary>
        public static List<Tile> Level1Tiles { get; set; }

        /// <summary>
        /// List of food in level 1.
        /// </summary>
        public static List<Food> Level1Food { get; set; }

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
        public static PlayerDir PlayerDirection { get; set; }

        /// <summary>
        /// The level 1 score.
        /// </summary>
        public static int Level1Score { get; set; }

        /// <summary>
        /// Gets or sets whether the game is over.
        /// </summary>
        public static bool IsGameOver { get; set; }
    }
}
