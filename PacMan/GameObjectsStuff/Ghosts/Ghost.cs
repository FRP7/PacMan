using System;
using System.Collections.Generic;
using System.Text;
using PacMan.GameObjectsStuff.Levels;
using PacMan.GameToolsStuff;
using System.Threading;

namespace PacMan.GameObjectsStuff.Ghosts
{
    /// <summary>
    /// Ghost NPC.
    /// </summary>
    public class Ghost : GameObject
    {
        /// <summary>
        /// Ghost X coordinate.
        /// </summary>
        public int GhostX { get; set; }

        /// <summary>
        /// Ghost X coordinate.
        /// </summary>
        public int GhostY { get; set; }

        /// <summary>
        /// Old ghost X coordinate.
        /// </summary>
        public int OldGhostX { get; set; }

        /// <summary>
        /// Old ghost Y coordinate.
        /// </summary>
        public int OldGhostY { get; set; }

        /// <summary>
        /// Ghost sprite.
        /// </summary>
        public char Sprite { get; set; }

        /// <summary>
        /// Ghost direction.
        /// </summary>
        public GhostDir GhostDirection { get; set; }

        /// <summary>
        /// To be played in the first frame of the game.
        /// Setup stuff.
        /// </summary>
        public override void Start()
        {
            Sprite = 'G';
        }

        /// <summary>
        /// To be played in every frame.
        /// Update the game logic, physics etc.
        /// </summary>
        public override void Update()
        {
            MoveLoop();
        }

        /// <summary>
        /// To be played in every frame after update.
        /// Render the game.
        /// </summary>
        public override void Render()
        {
            RenderGhost();
        }

        /// <summary>
        /// Render the ghost.
        /// </summary>
        public void RenderGhost()
        {
            Console.SetCursorPosition(OldGhostX, OldGhostY);
            Console.Write(" ");
            Console.SetCursorPosition(GhostX, GhostY);
            Console.Write(Sprite);
        }

        /// <summary>
        /// Move loop.
        /// </summary>
        private void MoveLoop()
        {
            GhostDirection = GetRandomDirection();
            MoveAction();
            Timer();
        }

        private void Timer()
        {
            int i = 10000;

            while(i != 0)
            {
                i -= 1;
            }
        }

        private void MoveAction()
        {
            OldGhostX = GhostX;
            OldGhostY = GhostY;

            switch (GhostDirection)
            {
                case GhostDir.Up:
                    if (GhostY > 0 && CheckMove(GhostX, GhostY - 1))
                    {
                        GhostY--;
                    }
                    break;
                case GhostDir.Down:
                    if (CheckMove(GhostX, GhostY + 1))
                    {
                        GhostY++;
                    }
                    break;
                case GhostDir.Left:
                    if (GhostX > 0 && CheckMove(GhostX - 1, GhostY))
                    {
                        GhostX--;
                    }
                    break;
                case GhostDir.Right:
                    if (CheckMove(GhostX + 1, GhostY))
                    {
                        GhostX++;
                    }
                    break;
            }
        }

        /// <summary>
        /// Checks whether the move is legal.
        /// </summary>
        /// <param name="newX"> New player x coordinate.</param>
        /// <param name="newY"> New player y coordinate.</param>
        /// <returns></returns>
        public bool CheckMove(int newX, int newY)
        {
            bool isLegal = true;

            foreach (Tile tile in GameData.Level1Tiles)
            {
                if (tile.X == newX && tile.Y == newY)
                {
                    isLegal = false;
                }
            }

            return isLegal;
        }

        /// <summary>
        /// Choose a random direction.
        /// </summary>
        /// <returns> Ghost direction.</returns>
        private GhostDir GetRandomDirection()
        {
            Random rnd = new Random();
            int rndNumb = rnd.Next(0, 4);

            if (rndNumb == 0)
            {
                return GhostDir.Down;
            }
            else if (rndNumb == 1)
            {
                return GhostDir.Left;
            }
            else if (rndNumb == 2)
            {
                return GhostDir.Right;
            }
            else
            {
                return GhostDir.Up;
            }
        }

        public Ghost(int x, int y)
        {
            GhostX = x;
            GhostY = y;
        }
    }
}
