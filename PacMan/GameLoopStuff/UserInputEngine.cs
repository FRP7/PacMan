using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using PacMan.GameObjectsStuff.Player;
using PacMan.GameToolsStuff;

namespace PacMan.GameLoopStuff
{
    /// <summary>
    /// Detect the player's input.
    /// </summary>
    public class UserInputEngine
    {
        /// <summary>
        /// Access the console key.
        /// </summary>
        public ConsoleKey GetKey { get; private set; }

        /// <summary>
        /// Thread lock key.
        /// </summary>
        private object threadLock;

        /// <summary>
        /// Detect the user input in a different thread.
        /// </summary>
        public void UserInput()
        {
            Thread inputThread = new Thread(ReadKeys);
            inputThread.Start();
            inputThread.Join();
        }

        /// <summary>
        /// Read the keys.
        /// </summary>
        private void ReadKeys()
        {
            lock (threadLock)
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

        /// <summary>
        /// UserInputEngine constructor.
        /// </summary>
        public UserInputEngine()
        {
            threadLock = new object();
        }
    }
}
