using System;
using System.Collections.Generic;
using System.Text;
using PacMan.GameObjectsStuff;
using PacMan.GameToolsStuff;

namespace PacMan.GameLoopStuff
{
    /// <summary>
    /// Update the game class.
    /// </summary>
    public class UpdateEngine
    {
        /// <summary>
        /// Update the game logic, physics etc.
        /// </summary>
        public void Update()
        {
            foreach (GameObject item in GameData.GameObjects)
            {
                item.Update();
            }
        }
    }
}
