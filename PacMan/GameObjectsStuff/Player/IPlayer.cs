using System;
using System.Collections.Generic;
using System.Text;

namespace PacMan.GameObjectsStuff.Player
{
    /// <summary>
    /// Player interface.
    /// </summary>
    public interface IPlayer
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
        /// Update the player current position.
        /// </summary>
        public void UpdatePlayerPosition();

        /// <summary>
        /// Render the player.
        /// </summary>
        public void RenderPlayer();

        /// <summary>
        /// Checks whether the move is legal.
        /// </summary>
        public bool CheckMove(int newX, int newY);

        /// <summary>
        /// Checks if Pac Man eats food.
        /// </summary>
        public void CheckFood();
    }
}
