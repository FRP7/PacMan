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
            Scene();
        }

        private void InitializeTiles()
        {
            tiles = new List<Tile>();
        }

        private void Scene()
        {
            // topo
            Console.SetCursorPosition(0, 0);
            Console.Write("High Score: ");

            // lado esquerdo
            for (int i = 2; i < 25; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write('|');
            }

            // lado direito
            for (int i = 2; i < 25; i++)
            {
                Console.SetCursorPosition(70, i);
                Console.Write('|');
            }

            // lado de cima
            for (int i = 0; i < 71; i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write('_');
            }

            // lado de baixo
            for (int i = 0; i < 71; i++)
            {
                Console.SetCursorPosition(i, 24);
                Console.Write('_');
            }

            // obstaculo 1
            for (int i = 7; i < 27; i++)
            {
                Console.SetCursorPosition(i, 4);
                Console.Write('_');
            }
            for (int i = 7; i < 27; i++)
            {
                Console.SetCursorPosition(i, 5);
                Console.Write('_');
            }
            Console.SetCursorPosition(6, 5);
            Console.Write('|');
            Console.SetCursorPosition(27, 5);
            Console.Write('|');

            // obstaculo 2
            for (int i = 2; i < 6; i++)
            {
                Console.SetCursorPosition(34, i);
                Console.Write('|');
            }
            for (int i = 2; i < 6; i++)
            {
                Console.SetCursorPosition(36, i);
                Console.Write('|');
            }
            Console.SetCursorPosition(35, 5);
            Console.Write('_');

            // obstaculo 3
            for (int i = 44; i < 63; i++)
            {
                Console.SetCursorPosition(i, 4);
                Console.Write('_');
            }
            for (int i = 44; i < 63; i++)
            {
                Console.SetCursorPosition(i, 5);
                Console.Write('_');
            }
            Console.SetCursorPosition(43, 5);
            Console.Write('|');
            Console.SetCursorPosition(63, 5);
            Console.Write('|');

            //obstaculo 4
            for (int i = 9; i < 21; i++)
            {
                Console.SetCursorPosition(6, i);
                Console.Write('|');
            }
            for (int i = 9; i < 21; i++)
            {
                Console.SetCursorPosition(8, i);
                Console.Write('|');
            }
            Console.SetCursorPosition(7, 8);
            Console.Write('_');
            Console.SetCursorPosition(7, 20);
            Console.Write('_');

            // obstaculo 5
            for (int i = 9; i < 15; i++)
            {
                Console.SetCursorPosition(15, i);
                Console.Write('|');
            }
            for (int i = 10; i < 14; i++)
            {
                Console.SetCursorPosition(17, i);
                Console.Write('|');
            }
            for (int i = 10; i < 14; i++)
            {
                Console.SetCursorPosition(25, i);
                Console.Write('|');
            }
            for (int i = 9; i < 21; i++)
            {
                Console.SetCursorPosition(27, i);
                Console.Write('|');
            }
            for (int i = 15; i < 28; i++)
            {
                Console.SetCursorPosition(i, 8);
                Console.Write('_');
            }
            for (int i = 18; i < 25; i++)
            {
                Console.SetCursorPosition(i, 9);
                Console.Write('_');
            }
            for (int i = 18; i < 25; i++)
            {
                Console.SetCursorPosition(i, 13);
                Console.Write('_');
            }
            for (int i = 15; i < 25; i++)
            {
                Console.SetCursorPosition(i, 14);
                Console.Write('_');
            }
            for (int i = 15; i < 21; i++)
            {
                Console.SetCursorPosition(25, i);
                Console.Write('|');
            }
            Console.SetCursorPosition(26, 20);
            Console.Write('_');

            // obstaculo 6
            for (int i = 9; i < 21; i++)
            {
                Console.SetCursorPosition(34, i);
                Console.Write('|');
            }
            for (int i = 9; i < 21; i++)
            {
                Console.SetCursorPosition(44, i);
                Console.Write('|');
            }
            for (int i = 34; i < 45; i++)
            {
                Console.SetCursorPosition(i, 8);
                Console.Write('_');
            }
            for (int i = 34; i < 45; i++)
            {
                Console.SetCursorPosition(i, 20);
                Console.Write('_');
            }

            // obstaculo 7
            for (int i = 9; i < 21; i++)
            {
                Console.SetCursorPosition(53, i);
                Console.Write('|');
            }
            for (int i = 9; i < 21; i++)
            {
                Console.SetCursorPosition(63, i);
                Console.Write('|');
            }
            for (int i = 53; i < 64; i++)
            {
                Console.SetCursorPosition(i, 8);
                Console.Write('_');
            }
            for (int i = 53; i < 64; i++)
            {
                Console.SetCursorPosition(i, 20);
                Console.Write('_');
            }
        }
    }
}
