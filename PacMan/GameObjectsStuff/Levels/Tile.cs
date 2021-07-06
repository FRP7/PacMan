using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace PacMan.GameObjectsStuff.Levels
{
    /// <summary>
    /// Stats of the tiles in the game.
    /// </summary>
    public struct Tile
    {
        /// <summary>
        /// Tile X coordinates.
        /// </summary>
        public int X { get; }

        /// <summary>
        /// Tile Y coordinates.
        /// </summary>
        public int Y { get; }

        /// <summary>
        /// Tile sprite.
        /// </summary>
        public char Sprite { get; }

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
                    return X;
                }
                else if(index == 1)
                {
                    return Y;
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
                    return X.ToString();
                }
                else if (index == "0" || string.Equals(index, "x", StringComparison.CurrentCultureIgnoreCase))
                {
                    return Y.ToString();
                }
                else if (index == "0" || string.Equals(index, "x", StringComparison.CurrentCultureIgnoreCase))
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
        /// <param name="v1"> Tile to be compared.</param>
        /// <param name="v2"> Tile to be compared.</param>
        /// <returns> Tile.</returns>
        public static Tile operator +(Tile v1, Tile v2)
            => new Tile((v1.X + v2.X), (v1.Y + v2.Y), v1.Sprite);

        /// <summary>
        /// Subtract operator overloading.
        /// </summary>
        /// <param name="v1"> Tile to be compared.</param>
        /// <param name="v2"> Tile to be compared.</param>
        /// <returns> Tile.</returns>
        public static Tile operator -(Tile v1, Tile v2)
            => new Tile((v1.X - v2.X), (v1.Y - v2.Y), v1.Sprite);

        /// <summary>
        /// Multiply operator overloading.
        /// </summary>
        /// <param name="v1"> Tile to be compared.</param>
        /// <param name="v2"> Tile to be compared.</param>
        /// <returns> Tile.</returns>
        public static Tile operator *(Tile v1, Tile v2)
            => new Tile((v1.X * v2.X), (v1.Y * v2.Y), v1.Sprite);

        /// <summary>
        /// Divide operator overloading.
        /// </summary>
        /// <param name="v1"> Tile to be compared.</param>
        /// <param name="v2"> Tile to be compared.</param>
        /// <returns> Tile.</returns>
        public static Tile operator /(Tile v1, Tile v2)
            => new Tile((v1.X / v2.X), (v1.Y / v2.Y), v1.Sprite);

        /// <summary>
        /// "==" operator overloading.
        /// </summary>
        /// <param name="v1"> Tile to be compared.</param>
        /// <param name="v2"> Tile to be compared.</param>
        /// <returns> Tile.</returns>
        public static bool operator == (Tile v1, Tile v2)
        {
            if((v1.X == v2.X) && (v1.Y == v2.Y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Convert Food to Vector2.
        /// </summary>
        /// <param name="input"> Input</param>
        public static explicit operator Vector2 (Tile input)
            => new Vector2(input.X, input.Y);

        /// <summary>
        /// "!=" operator overloading.
        /// </summary>
        /// <param name="v1"> Tile to be compared.</param>
        /// <param name="v2"> Tile to be compared.</param>
        /// <returns> Tile.</returns>
        public static bool operator != (Tile v1, Tile v2)
        {
            if ((v1.X == v2.X) && (v1.Y == v2.Y))
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
        /// <param name="v1"> Tile to be compared.</param>
        /// <param name="v2"> Tile to be compared.</param>
        /// <returns> Tile.</returns>
        public static bool operator  < (Tile v1, Tile v2)
        {
            if ((v1.X < v2.X) && (v1.Y < v2.Y))
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
        /// <param name="v1"> Tile to be compared.</param>
        /// <param name="v2"> Tile to be compared.</param>
        /// <returns> Tile.</returns>
        public static bool operator > (Tile v1, Tile v2)
        {
            if ((v1.X > v2.X) && (v1.Y > v2.Y))
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
        /// <param name="v1"> Tile to be compared.</param>
        /// <param name="v2"> Tile to be compared.</param>
        /// <returns> Tile.</returns>
        public static bool operator >= (Tile v1, Tile v2)
        {
            if ((v1.X >= v2.X) && (v1.Y >= v2.Y))
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
        /// <param name="v1"> Tile to be compared.</param>
        /// <param name="v2"> Tile to be compared.</param>
        /// <returns> Tile.</returns>
        public static bool operator <= (Tile v1, Tile v2)
        {
            if ((v1.X <= v2.X) && (v1.Y <= v2.Y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Tile constructor.
        /// </summary>
        /// <param name="x"> Tile x coordinates.</param>
        /// <param name="y"> Tile y coordinates. </param>
        /// <param name="sprite"> Tile sprite. </param>
        public Tile(int x, int y, char sprite)
        {
            X = x;
            Y = y;
            Sprite = sprite;
        }

        /// <summary>
        /// Print the struct.
        /// </summary>
        /// <returns> Modified string.</returns>
        public override string ToString()
        {
            return $"X: {X}, Y: {Y}, Sprite: {Sprite}";
        }
    }
}
