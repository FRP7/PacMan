using System;
using System.Collections.Generic;
using System.Text;
using PacMan.GameToolsStuff;
using PacMan.GameObjectsStuff.Levels;
using PacMan.GameObjectsStuff.Foods;

namespace PacMan.GameObjectsStuff.Player
{
    /// <summary>
    /// Pac Man character gameobject (controller by the player).
    /// </summary>
    public class Pac : GameObject, IPlayer
    {
        /// <summary>
        /// Gets or sets the Player's X coordinates.
        /// </summary>
        public int PlayerX { get; set; }

        /// <summary>
        /// Gets or sets the Player's Y coordinates.
        /// </summary>
        public int PlayerY { get; set; }

        /// <summary>
        /// Gets or sets the Player's old X coordinates.
        /// </summary>
        public int OldPlayerX { get; set; }

        /// <summary>
        /// Gets or sets the Player's old Y coordinates.
        /// </summary>
        public int OldPlayerY { get; set; }

        /// <summary>
        /// Gets or sets the Player's sprite.
        /// </summary>
        public char Sprite { get; set; }

        /// <summary>
        /// To be played in the first frame of the game.
        /// Setup stuff.
        /// </summary>
        public override void Start()
        {
            PlayerX = 2;
            PlayerY = 4;
            Sprite = 'C';
        }

        /// <summary>
        /// To be played in every frame.
        /// Update the game logic, physics etc.
        /// </summary>
        public override void Update()
        {
            UpdatePlayerPosition();
            CheckFood();
        }

        /// <summary>
        /// To be played in every frame after update.
        /// Render the game.
        /// </summary>
        public override void Render()
        {
            RenderPlayer();
        }

        /// <summary>
        /// Update the player current position.
        /// </summary>
        public void UpdatePlayerPosition()
        {
            if (GameData.PlayerDirection != Dir.None)
            {
                OldPlayerX = PlayerX;
                OldPlayerY = PlayerY;

                switch (GameData.PlayerDirection)
                {
                    case Dir.Up:
                        if (PlayerY > 0 && CheckMove(PlayerX, PlayerY - 1))
                        {
                            PlayerY--;
                        }
                        break;
                    case Dir.Down:
                        if (CheckMove(PlayerX, PlayerY + 1))
                        {
                            PlayerY++;
                        }
                        break;
                    case Dir.Left:
                        if (PlayerX > 0 && CheckMove(PlayerX - 1, PlayerY))
                        {
                            PlayerX--;
                        }
                        break;
                    case Dir.Right:
                        if (CheckMove(PlayerX + 1, PlayerY))
                        {
                            PlayerX++;
                        }
                        break;
                }
                GameData.PlayerDirection = Dir.None;
                GameData.PlayerX = PlayerX;
                GameData.PlayerY = PlayerY;
            }
        }

        /// <summary>
        /// Render the player.
        /// </summary>
        public void RenderPlayer()
        {
            Console.SetCursorPosition(OldPlayerX, OldPlayerY);
            Console.Write(" ");
            Console.SetCursorPosition(PlayerX, PlayerY);
            Console.Write(Sprite);
        }

        /// <summary>
        /// Checks whether the move is legal.
        /// </summary>
        /// <param name="newX"> New player x coordinate.</param>
        /// <param name="newY"> New player y coordinate.</param>
        /// <returns></returns>
        public bool CheckMove(int newX, int newY)
        {
            bool isLegal = true;

            foreach (Tile tile in GameData.Level1Tiles)
            {
                if (tile.X == newX && tile.Y == newY)
                {
                    isLegal = false;
                }
            }

            return isLegal;
        }

        /// <summary>
        /// Checks if Pac Man eats food.
        /// </summary>
        public void CheckFood()
        {
            for(int i = 0; i < GameData.Level1Food.Count; i++)
            {
                if (GameData.Level1Food[i].FoodX == PlayerX && GameData.Level1Food[i].FoodY == PlayerY)
                {
                    GameData.Level1Food.Remove(GameData.Level1Food[i]);
                    GameData.Level1Score += 1;
                }
            }
        }
    }
}
