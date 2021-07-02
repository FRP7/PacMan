using System;
using System.Collections.Generic;
using System.Text;

namespace PacMan.GameObjects
{
    public class GameScene : GameObject
    {
        private List<Tile> tiles;

        public override void Start()
        {
            InitializeTiles();
        }

        public override void Update()
        {

        }

        public override void Render()
        {
            UI();

            foreach (Tile item in tiles)
            {
                Console.SetCursorPosition(item.X, item.Y);
                Console.Write(item.Sprite);
            }
        }

        private void InitializeTiles()
        {
            tiles = new List<Tile>();

            // vertical
            for (int i = 2; i < 25; i++)
            {
                tiles.Add(new Tile(0, i, '|'));
                tiles.Add(new Tile(70, i, '|'));
            }

            // horizontal
            for (int i = 0; i < 71; i++)
            {
                tiles.Add(new Tile(i, 1, '_'));
                tiles.Add(new Tile(i, 24, '_'));
            }

            // obstaculo 1
            for (int i = 7; i < 27; i++)
            {
                tiles.Add(new Tile(i, 4, '_'));
                tiles.Add(new Tile(i, 5, '_'));
            }
            tiles.Add(new Tile(6, 5, '|'));
            tiles.Add(new Tile(27, 5, '|'));

            // obstaculo 2
            for (int i = 2; i < 6; i++)
            {
                tiles.Add(new Tile(34, i, '|'));
                tiles.Add(new Tile(36, i, '|'));
            }
            tiles.Add(new Tile(35, 5, '_'));

            // obstaculo 3
            for (int i = 44; i < 63; i++)
            {
                tiles.Add(new Tile(i, 4, '_'));
                tiles.Add(new Tile(i, 5, '_'));
            }
            tiles.Add(new Tile(43, 5, '|'));
            tiles.Add(new Tile(63, 5, '|'));

            //obstaculo 4
            for (int i = 9; i < 21; i++)
            {
                tiles.Add(new Tile(6, i, '|'));
                tiles.Add(new Tile(8, i, '|'));
            }
            tiles.Add(new Tile(7, 8, '_'));
            tiles.Add(new Tile(7, 20, '_'));

            // obstaculo 5
            for (int i = 9; i < 15; i++)
            {
                tiles.Add(new Tile(15, i, '|'));
            }
            for (int i = 10; i < 14; i++)
            {
                tiles.Add(new Tile(17, i, '|'));
                tiles.Add(new Tile(25, i, '|'));
            }
            for (int i = 9; i < 21; i++)
            {
                tiles.Add(new Tile(27, i, '|'));
            }
            for (int i = 15; i < 28; i++)
            {
                tiles.Add(new Tile(i, 8, '_'));
            }
            for (int i = 18; i < 25; i++)
            {
                tiles.Add(new Tile(i, 9, '_'));
                tiles.Add(new Tile(i, 13, '_'));
            }
            for (int i = 15; i < 25; i++)
            {
                tiles.Add(new Tile(i, 14, '_'));
            }
            for (int i = 15; i < 21; i++)
            {
                tiles.Add(new Tile(25, i, '|'));
            }
            tiles.Add(new Tile(26, 20, '_'));

            // obstaculo 6
            for (int i = 9; i < 21; i++)
            {
                tiles.Add(new Tile(34, i, '|'));
                tiles.Add(new Tile(44, i, '|'));
            }
            for (int i = 34; i < 45; i++)
            {
                tiles.Add(new Tile(i, 8, '_'));
                tiles.Add(new Tile(i, 20, '_'));
            }

            // obstaculo 7
            for (int i = 9; i < 21; i++)
            {
                tiles.Add(new Tile(53, i, '|'));
                tiles.Add(new Tile(63, i, '|'));
            }
            for (int i = 53; i < 64; i++)
            {
                tiles.Add(new Tile(i, 8, '_'));
                tiles.Add(new Tile(i, 20, '_'));
            }
        }

        private void UI()
        {
            // topo
            Console.SetCursorPosition(0, 0);
            Console.Write("High Score: ");
        }
    }
}
