using System;
using System.Collections.Generic;
using System.Text;

namespace PacMan.GameObjectsStuff.Player
{
    public interface IPlayer
    {
        public int PlayerX { get; set; }
        public int PlayerY { get; set; }
        public int OldPlayerX { get; set; }
        public int OldPlayerY { get; set; }
        public char Sprite { get; set; }

        public void UpdatePlayerPosition();

        public void RenderPlayer();
    }
}
