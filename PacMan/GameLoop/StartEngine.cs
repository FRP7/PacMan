using System;
using System.Collections.Generic;
using System.Text;
using PacMan.GameObjects;

namespace PacMan.GameLoop
{
    /// <summary>
    /// Start the game.
    /// </summary>
    public class StartEngine
    {
        /// <summary>
        /// To be played in the first frame of the game.
        /// Setup the game.
        /// </summary>
        public void Start()
        {
            foreach(GameObject item in GameData.GameObjects)
            {
                item.Start();
            }
        }
    }
}
