using System;
using System.Collections.Generic;
using System.Text;
using PacMan.GameLoop;

namespace PacMan.GameObjects
{
    public class Pac : GameObject
    {
        private int playerX;
        private int playerY;

        private int oldPlayerX;
        private int oldPlayerY;

        private char sprite;

        public override void Start()
        {
            playerX = 3;
            playerY = 3;
            sprite = 'C';
        }

        public override void Update()
        {
            UpdatePlayerPosition();
        }

        public override void Render()
        {
            DrawPlayer();
        }

        private void UpdatePlayerPosition()
        {
            if (GameData.PlayerDirection != Dir.None)
            {
                oldPlayerX = playerX;
                oldPlayerY = playerY;

                switch (GameData.PlayerDirection)
                {
                    case Dir.Up:
                        if (playerY > 0)
                        {
                            playerY--;
                            Console.Clear();
                        }
                        break;
                    case Dir.Down:
                        playerY++;
                        Console.Clear();
                        break;
                    case Dir.Left:
                        if (playerX > 0)
                        {
                            playerX--;
                            Console.Clear();
                        }
                        break;
                    case Dir.Right:
                        playerX++;
                        Console.Clear();
                        break;
                }
                GameData.PlayerDirection = Dir.None;
                GameData.PlayerX = playerX;
                GameData.PlayerY = playerY;
            }
        }

        private void DrawPlayer()
        {
            Console.SetCursorPosition(oldPlayerX, oldPlayerY);
            Console.Write(" ");
            Console.SetCursorPosition(playerX, playerY);
            Console.Write(sprite);
        }
    }
}
