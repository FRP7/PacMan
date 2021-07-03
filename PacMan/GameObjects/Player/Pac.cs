using System;
using System.Collections.Generic;
using System.Text;
using PacMan.GameLoop;

namespace PacMan.GameObjects.Player
{
    public class Pac : GameObject, IPlayer
    {
        public int PlayerX { get; set; }
        public int PlayerY { get; set; }

        public int OldPlayerX { get; set; }
        public int OldPlayerY { get; set; }

        public char Sprite { get; set; }

        public override void Start()
        {
            PlayerX = 3;
            PlayerY = 3;
            Sprite = 'C';
        }

        public override void Update()
        {
            UpdatePlayerPosition();
        }

        public override void Render()
        {
            RenderPlayer();
        }

        public void UpdatePlayerPosition()
        {
            if (GameData.PlayerDirection != Dir.None)
            {
                OldPlayerX = PlayerX;
                OldPlayerY = PlayerY;

                switch (GameData.PlayerDirection)
                {
                    case Dir.Up:
                        if (PlayerY > 0)
                        {
                            PlayerY--;
                            Console.Clear();
                        }
                        break;
                    case Dir.Down:
                        PlayerY++;
                        Console.Clear();
                        break;
                    case Dir.Left:
                        if (PlayerX > 0)
                        {
                            PlayerX--;
                            Console.Clear();
                        }
                        break;
                    case Dir.Right:
                        PlayerX++;
                        Console.Clear();
                        break;
                }
                GameData.PlayerDirection = Dir.None;
                GameData.PlayerX = PlayerX;
                GameData.PlayerY = PlayerY;
            }
        }

        public void RenderPlayer()
        {
            Console.SetCursorPosition(OldPlayerX, OldPlayerY);
            Console.Write(" ");
            Console.SetCursorPosition(PlayerX, PlayerY);
            Console.Write(Sprite);
        }
    }
}
