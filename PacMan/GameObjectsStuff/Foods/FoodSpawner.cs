using System;
using System.Collections.Generic;
using System.Text;
using PacMan.GameObjectsStuff;
using PacMan.GameToolsStuff;

namespace PacMan.GameObjectsStuff.Foods
{
    /// <summary>
    /// Spawner of foods for pac man to eat and increase the score.
    /// </summary>
    public class FoodSpawner : GameObject
    {
        /// <summary>
        /// List of foods in the level.
        /// </summary>
        private List<Food> foodList;

        /// <summary>
        /// To be played in the first frame of the game.
        /// Setup stuff.
        /// </summary>
        public override void Start()
        {
            foodList = new List<Food>();
            SetUpFood();
            //foodList.Add(new Food(5, 3, 'o'));
            //foodList.Add(new Food(8, 3, 'o'));
            //GameData.Level1Food = foodList;
        }

        /// <summary>
        /// To be played in every frame.
        /// Update the game logic, physics etc.
        /// </summary>
        public override void Update()
        {
            foodList = GameData.Level1Food;
        }

        /// <summary>
        /// To be played in every frame after update.
        /// Render the game.
        /// </summary>
        public override void Render()
        {
            foreach(Food food in foodList)
            {
                Console.SetCursorPosition(food.FoodX, food.FoodY);
                Console.Write(food.Sprite);
            }
        }

        /// <summary>
        /// Set up the food.
        /// </summary>
        private void SetUpFood()
        {
            // horizontals
            for(int i = 5; i < 29; i+= 3)
            {
                foodList.Add(new Food(i, 3, 'o'));
            }
            for (int i = 42; i < 66; i += 3)
            {
                foodList.Add(new Food(i, 3, 'o'));
            }
            for (int i = 6; i < 66; i += 3)
            {
                foodList.Add(new Food(i, 7, 'o'));
                foodList.Add(new Food(i, 23, 'o'));
            }

            // verticals
            for (int i = 5; i < 23; i += 2)
            {
                foodList.Add(new Food(3, i, 'o'));
                foodList.Add(new Food(30, i, 'o'));
            }
            for (int i = 7; i < 25; i += 2)
            {
                foodList.Add(new Food(12, i, 'o'));
            }
            for (int i = 15; i < 22; i += 2)
            {
                foodList.Add(new Food(15, i, 'o'));
                foodList.Add(new Food(18, i, 'o'));
                foodList.Add(new Food(21, i, 'o'));
                foodList.Add(new Food(24, i, 'o'));
            }
            for (int i = 7; i < 25; i += 2)
            {
                foodList.Add(new Food(48, i, 'o'));
            }
            for (int i = 5; i < 25; i += 2)
            {
                foodList.Add(new Food(67, i, 'o'));
            }
            for (int i = 5; i < 7; i += 2)
            {
                foodList.Add(new Food(39, i, 'o'));
            }

            GameData.Level1Food = foodList;
        }
    }
}
