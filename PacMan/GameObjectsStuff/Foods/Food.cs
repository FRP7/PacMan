using System;
using System.Collections.Generic;
using System.Text;

namespace PacMan.GameObjectsStuff.Foods
{
    /// <summary>
    /// Stats of each food.
    /// </summary>
    public struct Food
    {
        /// <summary>
        /// Food X coordinate.
        /// </summary>
        public int FoodX { get; }

        /// <summary>
        /// Food Y coordinate.
        /// </summary>
        public int FoodY { get; }

        /// <summary>
        /// Food sprite.
        /// </summary>
        public char Sprite { get; set; }

        /// <summary>
        /// Food constructor.
        /// </summary>
        /// <param name="foodX"> Food X coordinate.</param>
        /// <param name="foodY"> Food Y coordinate.</param>
        /// <param name="sprite"> Food sprite.</param>
        public Food(int foodX, int foodY, char sprite)
        {
            FoodX = foodX;
            FoodY = foodY;
            Sprite = sprite;
        }
    }
}
