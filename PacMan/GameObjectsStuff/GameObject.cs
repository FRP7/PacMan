using System;
using System.Collections.Generic;
using System.Text;

namespace PacMan.GameObjectsStuff
{
    /// <summary>
    /// GameObject mother class.
    /// </summary>
    public abstract class GameObject
    {
        /// <summary>
        /// To be played in the first frame of the game.
        /// Setup stuff.
        /// </summary>
        public abstract void Start();

        /// <summary>
        /// To be played in every frame.
        /// Update the game logic, physics etc.
        /// </summary>
        public abstract void Update();

        /// <summary>
        /// To be played in every frame after update.
        /// Render the game.
        /// </summary>
        public abstract void Render();
    }
}
