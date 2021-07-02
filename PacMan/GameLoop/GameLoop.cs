using System;
using System.Collections.Generic;
using System.Text;

namespace PacMan.GameLoop
{
    /// <summary>
    /// Manage the game loop.
    /// </summary>
    public class GameLoop
    {
        /// <summary>
        /// Access the StartEngine class.
        /// </summary>
        private StartEngine startEngine;
        /// <summary>
        /// Access the UserInputEngine class.
        /// </summary>
        private UserInputEngine userInputEngine;
        /// <summary>
        /// Access the RenderEngine class.
        /// </summary>
        private RenderEngine renderEngine;
        /// <summary>
        /// Access the UpdateEngine class.
        /// </summary>
        private UpdateEngine updateEngine;

        /// <summary>
        /// Run the game loop.
        /// </summary>
        private void Game()
        {
            Start();
            Update();
        }

        /// <summary>
        /// To be played in the first frame of the game.
        /// </summary>
        private void Start()
        {
            startEngine.Start();
        }

        /// <summary>
        /// To be played in every frame.
        /// </summary>
        private void Update()
        {
            while(true)
            {
                userInputEngine.UserInput();
                updateEngine.Update();
                renderEngine.Render();
            }
        }

        /// <summary>
        /// GameLoop constructor.
        /// </summary>
        public GameLoop()
        {
            startEngine = new StartEngine();
            userInputEngine = new UserInputEngine();
            renderEngine = new RenderEngine();
            updateEngine = new UpdateEngine();
        }
    }
}
