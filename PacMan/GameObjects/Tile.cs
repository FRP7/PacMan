using System;
using System.Collections.Generic;
using System.Text;

namespace PacMan.GameObjects
{
    public struct Tile
    {
        public int X { get; }
        public int Y { get; }
        public char Sprite { get; }

        public Tile(int x, int y, char sprite)
        {
            X = x;
            Y = y;
            Sprite = sprite;
        }
    }
}
