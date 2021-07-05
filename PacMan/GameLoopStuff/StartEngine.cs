using System;
using System.Collections.Generic;
using System.Text;
using PacMan.GameToolsStuff;
using PacMan.GameObjectsStuff;
using PacMan.GameObjectsStuff.Player;
using PacMan.GameObjectsStuff.Levels;
using PacMan.GameLoopStuff;

namespace PacMan.GameLoopStuff
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

            foreach (GameObject item in GameData.Ghosts)
            {
                item.Start();
            }
        }
    }
}
