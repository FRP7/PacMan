using System;
using System.Collections.Generic;
using System.Text;

namespace PacMan.GameObjectsStuff.Levels
{
    /// <summary>
    /// Stats of the tiles in the game.
    /// </summary>
    public struct Tile
    {
        /// <summary>
        /// Tile X coordinates.
        /// </summary>
        public int X { get; }

        /// <summary>
        /// Tile Y coordinates.
        /// </summary>
        public int Y { get; }

        /// <summary>
        /// Tile sprite.
        /// </summary>
        public char Sprite { get; }

        /// <summary>
        /// Tile constructor.
        /// </summary>
        /// <param name="x"> Tile x coordinates.</param>
        /// <param name="y"> Tile y coordinates. </param>
        /// <param name="sprite"> Tile sprite. </param>
        public Tile(int x, int y, char sprite)
        {
            X = x;
            Y = y;
            Sprite = sprite;
        }
    }
}
