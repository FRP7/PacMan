using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using PacMan.GameObjectsStuff.Player;
using PacMan.GameToolsStuff;

namespace PacMan.GameLoopStuff
{
    public class UserInputEngine
    {
        public ConsoleKey GetKey { get; private set; }

        public void UserInput()
        {
            Thread inputThread = new Thread(ReadKeys);
            inputThread.Start();
            inputThread.Join();
        }

        private void ReadKeys()
        {
            if (Console.KeyAvailable)
            {
                GetKey = Console.ReadKey(true).Key;

                switch (GetKey)
                {
                    case ConsoleKey.UpArrow:
                        GameData.PlayerDirection = Dir.Up;
                        break;

                    case ConsoleKey.DownArrow:
                        GameData.PlayerDirection = Dir.Down;
                        break;

                    case ConsoleKey.LeftArrow:
                        GameData.PlayerDirection = Dir.Left;
                        break;

                    case ConsoleKey.RightArrow:
                        GameData.PlayerDirection = Dir.Right;
                        break;

                    case ConsoleKey.Escape:
                        // menu
                        break;
                }
            }
        }
    }
}
