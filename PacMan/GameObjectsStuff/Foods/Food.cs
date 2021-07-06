using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace PacMan.GameObjectsStuff.Foods
{
    /// <summary>
    /// Stats of each food.
    /// </summary>
    public struct Food
    {
        /// <summary>
        /// Food X coordinate.
        /// </summary>
        public int FoodX { get; }

        /// <summary>
        /// Food Y coordinate.
        /// </summary>
        public int FoodY { get; }

        /// <summary>
        /// Food sprite.
        /// </summary>
        public char Sprite { get; set; }

        /// <summary>
        /// Indexer.
        /// </summary>
        /// <param name="index"> Chosen index.</param>
        /// <returns> Property in int format.</returns>
        public int this[int index]
        {
            get
            {
                if(index == 0)
                {
                    return FoodX;
                }
                else if(index == 1)
                {
                    return FoodY;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        /// <summary>
        /// Indexer.
        /// </summary>
        /// <param name="index"> Chosen index.</param>
        /// <returns> Property in string format.</returns>
        public string this[string index]
        {
            get
            {
                if(index == "0" || string.Equals(index, "x", StringComparison.CurrentCultureIgnoreCase))
                {
                    return FoodX.ToString();
                }
                else if(index == "1" || string.Equals(index, "y", StringComparison.CurrentCultureIgnoreCase))
                {
                    return FoodY.ToString();
                }
                else if(index == "2" || string.Equals(index, "sprite", StringComparison.CurrentCultureIgnoreCase))
                {
                    return Sprite.ToString();
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        /// <summary>
        /// Sum operator overloading.
        /// </summary>
        /// <param name="v1"> Food to be compared.</param>
        /// <param name="v2"> Food to be compared.</param>
        /// <returns> Food.</returns>
        public static Food operator + (Food v1, Food v2)
        {
            return new Food((v1.FoodX + v2.FoodX), (v1.FoodY + v2.FoodY), v1.Sprite);
        }

        /// <summary>
        /// Subtraction operator overloading.
        /// </summary>
        /// <param name="v1"> Food to be compared.</param>
        /// <param name="v2"> Food to be compared.</param>
        /// <returns> Food.</returns>
        public static Food operator - (Food v1, Food v2)
        {
            return new Food((v1.FoodX - v2.FoodX), (v1.FoodY - v2.FoodY), v1.Sprite);
        }

        /// <summary>
        /// Multiply operator overloading.
        /// </summary>
        /// <param name="v1"> Food to be compared.</param>
        /// <param name="v2"> Food to be compared.</param>
        /// <returns> Food.</returns>
        public static Food operator * (Food v1, Food v2)
        {
            return new Food((v1.FoodX * v2.FoodX), (v1.FoodY * v2.FoodY), v1.Sprite);
        }

        /// <summary>
        /// Division operator overloading.
        /// </summary>
        /// <param name="v1"> Food to be compared.</param>
        /// <param name="v2"> Food to be compared.</param>
        /// <returns> Food.</returns>
        public static Food operator / (Food v1, Food v2)
        {
            return new Food((v1.FoodX / v2.FoodX), (v1.FoodY / v2.FoodY), v1.Sprite);
        }

        /// <summary>
        /// "==" operator overloading.
        /// </summary>
        /// <param name="v1"> Food to be compared.</param>
        /// <param name="v2"> Food to be compared.</param>
        /// <returns> Food.</returns>
        public static bool operator == (Food v1, Food v2)
        {
            if((v1.FoodX == v2.FoodX) && (v1.FoodY == v2.FoodY))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// "!=" operator overloading.
        /// </summary>
        /// <param name="v1"> Food to be compared.</param>
        /// <param name="v2"> Food to be compared.</param>
        /// <returns> Food.</returns>
        public static bool operator != (Food v1, Food v2)
        {
            if ((v1.FoodX != v2.FoodX) && (v1.FoodY != v2.FoodY))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// "<" operator overloading.
        /// </summary>
        /// <param name="v1"> Food to be compared.</param>
        /// <param name="v2"> Food to be compared.</param>
        /// <returns> Food.</returns>
        public static bool operator < (Food v1, Food v2)
        {
            if ((v1.FoodX < v2.FoodX) && (v1.FoodY < v2.FoodY))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// ">" operator overloading.
        /// </summary>
        /// <param name="v1"> Food to be compared.</param>
        /// <param name="v2"> Food to be compared.</param>
        /// <returns> Food.</returns>
        public static bool operator > (Food v1, Food v2)
        {
            if ((v1.FoodX > v2.FoodX) && (v1.FoodY > v2.FoodY))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// ">=" operator overloading.
        /// </summary>
        /// <param name="v1"> Food to be compared.</param>
        /// <param name="v2"> Food to be compared.</param>
        /// <returns> Food.</returns>
        public static bool operator >= (Food v1, Food v2)
        {
            if ((v1.FoodX >= v2.FoodX) && (v1.FoodY >= v2.FoodY))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// "<=" operator overloading.
        /// </summary>
        /// <param name="v1"> Food to be compared.</param>
        /// <param name="v2"> Food to be compared.</param>
        /// <returns> Food.</returns>
        public static bool operator <= (Food v1, Food v2)
        {
            if ((v1.FoodX <= v2.FoodX) && (v1.FoodY <= v2.FoodY))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Convert Vector2 to Food.
        /// </summary>
        /// <param name="input"> Input.</param>
        public static implicit operator Food (Vector2 input)
        {
            return new Food(Convert.ToInt32(input.X), Convert.ToInt32(input.Y), 'o');
        }

        /// <summary>
        /// Convert Food to Vector2.
        /// </summary>
        /// <param name="input"> Input.</param>
        public static explicit operator Vector2 (Food input)
        {
            return new Vector2(input.FoodX, input.FoodY);
        }

        /// <summary>
        /// Food constructor.
        /// </summary>
        /// <param name="foodX"> Food X coordinate.</param>
        /// <param name="foodY"> Food Y coordinate.</param>
        /// <param name="sprite"> Food sprite.</param>
        public Food(int foodX, int foodY, char sprite)
        {
            FoodX = foodX;
            FoodY = foodY;
            Sprite = sprite;
        }

        /// <summary>
        /// Print the struct.
        /// </summary>
        /// <returns> Modified string.</returns>
        public override string ToString()
        {
            return $"X: {FoodX}, Y: {FoodY}, Sprite: {Sprite}";
        }
    }
}
