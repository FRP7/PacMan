using System;
using System.Collections.Generic;
using System.Text;
using PacMan.GameToolsStuff;

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
            PlayerX = 3;
            PlayerY = 3;
            Sprite = 'C';
        }

        /// <summary>
        /// To be played in every frame.
        /// Update the game logic, physics etc.
        /// </summary>
        public override void Update()
        {
            UpdatePlayerPosition();
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
                        if (PlayerY > 0)
                        {
                            PlayerY--;
                        }
                        break;
                    case Dir.Down:
                        PlayerY++;
                        break;
                    case Dir.Left:
                        if (PlayerX > 0)
                        {
                            PlayerX--;
                        }
                        break;
                    case Dir.Right:
                        PlayerX++;
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
    }
}
