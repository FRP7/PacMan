using System;
using System.Collections.Generic;
using System.Text;
using PacMan.GameObjectsStuff;
using PacMan.GameToolsStuff;

namespace PacMan.GameLoopStuff
{
    /// <summary>
    /// Render the game.
    /// </summary>
    public class RenderEngine
    {
        /// <summary>
        /// Render the game level, characters etc.
        /// </summary>
        public void Render()
        {
            foreach (GameObject item in GameData.GameObjects)
            {
                item.Render();
            }
        }

        public RenderEngine()
        {
        }
    }
}
