using System;
using System.Collections.Generic;
using System.Text;

namespace Room
{
    class Room
    {
        Tile[][] tiles;
       
        public Room(int width, int height)
        {
            tiles = new Tile[height][];
            for (int y = 0; y < tiles.Length; y++)
            {
                tiles[y] = new Tile[width];

                for (int x = 0; x < tiles.Length; x++)
                {
                    tiles[y][x] = new Tile();
                }
            }
        }
    }
}